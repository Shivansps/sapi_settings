using Microsoft.Win32;
using SpeechLib;
using System;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

namespace SAPI_Settings
{
    public partial class MainUI : Form
    {
        Thread speakTH;
        String selectedVoice = "";
        String text = "";
        SpVoice speak = new SpVoice();

        public MainUI()
        {
            InitializeComponent();
            listVoices();
        }

        private void listVoices()
        {
            SpVoice listVoice = new SpVoice();

            voiceList.Items.Clear();
            foreach (ISpeechObjectToken obj in listVoice.GetVoices())
            {
                try
                {
                    var name = "";
                    var lang = "";
                    var gen = "";
                    var region = "";
                    try
                    {
                        name = obj.DataKey.OpenKey("Attributes").GetStringValue("Name");
                    }
                    catch {}
                    try
                    {
                        lang = obj.DataKey.OpenKey("Attributes").GetStringValue("Language");
                    }
                    catch { }
                    try
                    {
                        gen = obj.DataKey.OpenKey("Attributes").GetStringValue("Gender");
                    }
                    catch { }
                    try
                    {
                        region = obj.DataKey.GetStringValue("").Split('-')[1];
                    }
                    catch { }

                    ListViewItem item = new ListViewItem(new String[] {
                        name,
                        lang,
                        gen,
                        region
                    });
                    voiceList.Items.Add(item);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                
            }
        }

        private void speak_play_button_Click(object sender, EventArgs e)
        {
            if (this.voiceList.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem lv in voiceList.SelectedItems)
            {
                selectedVoice = lv.SubItems[0].Text;
            }
            text = testRichTextBox.Text;
            endSpeak();
            speakTH = new Thread(new ThreadStart(Speak));
            speakTH.Start();
        }

        
        private void stopSpeech_Click(object sender, EventArgs e)
        {
            endSpeak();
        }

        private void endSpeak() 
        {
            if (speakTH != null)
            {
                speak.Pause();
                speakTH.Abort();
            }
        }

        private void statusVoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.voiceList.SelectedItems.Count == 0)
                return;

            endSpeak();
            
            foreach (ListViewItem lv in voiceList.SelectedItems)
            {
                new Thread(() =>
                {
                    try
                    {
                        speak.Speak("<voice required='Name = " + lv.SubItems[0].Text + "'>" + "TEST");
                    }
                    catch { }
                }).Start();
            }
        }

        private void copyVoicesRegistry_Click(object sender, EventArgs e)
        {
            var newvoices = CopyVoicesTokens();
            newInstalledVoicesLabel.Text = newvoices.ToString();
            listVoices();
        }

        private void Speak()
        {
            try
            {
                speak = new SpVoice();
                speak.Speak("<voice required='Name = " + selectedVoice + "'>" +
                  "<rate speed='" + voiceRate.Value + "'>" +
                  "<volume level='" + voiceVolume.Value + "'>" +
                  "<pitch middle='" + voicePitch.Value + "'>" + text);
            }
            catch {}
        }

        public int CopyVoicesTokens()
        {
            int count = 0;
            try
            {
                using (RegistryKey oneCoreKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Speech_OneCore\Voices\Tokens"))
                {
                    using (RegistryKey sapiKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Speech\Voices\Tokens", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl))
                    {
                        if (oneCoreKey != null)
                        {
                            foreach (var token in oneCoreKey.GetSubKeyNames())
                            {
                                if (sapiKey.OpenSubKey(token) == null)
                                {
                                    //Copy Token
                                    RegistryKey newVoiceToken = sapiKey.CreateSubKey(token);
                                    foreach (var voiceData in oneCoreKey.OpenSubKey(token).GetValueNames())
                                    {
                                        var data = oneCoreKey.OpenSubKey(token).GetValue(voiceData);
                                        if(data is string)
                                        {
                                            //while copying it will replace the %windir% variable for the variable data, change it back
                                            if ((data as string).Contains(@":\WINDOWS"))
                                            {
                                                data = (data as string).Replace(@":\WINDOWS", "%windir%");
                                                data = (data as string).Remove(0, 1);
                                            }
                                        }
                                        newVoiceToken.SetValue(voiceData, data, oneCoreKey.OpenSubKey(token).GetValueKind(voiceData));
                                    }
                                    //Copy Token Attributes
                                    RegistryKey newVoiceAttributes = newVoiceToken.CreateSubKey("Attributes");
                                    foreach (var attName in oneCoreKey.OpenSubKey(token).OpenSubKey("Attributes").GetValueNames())
                                    {
                                        //This is no supported in sapi
                                        if (attName != "SayAsSupport")
                                        {
                                            newVoiceAttributes.SetValue(attName, oneCoreKey.OpenSubKey(token).OpenSubKey("Attributes").GetValue(attName), oneCoreKey.OpenSubKey(token).OpenSubKey("Attributes").GetValueKind(attName));
                                        }
                                    }
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return count;
            }
            return count;
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            endSpeak();
        }

        private void openSettingsWindows10_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ms-settings:speech");
            }
            catch { }
        }

        private void copyVoicesButton_Click(object sender, EventArgs e)
        {
            CopyVoicesTokens();
            listVoices();
        }
    }
}
