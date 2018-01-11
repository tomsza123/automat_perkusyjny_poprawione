using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NAudio;
using NAudio.Wave;
using System.Windows.Forms;
using NAudio.Utils;

namespace automat_perkusyjny
{
    
    
    class play
    {
        //static int bpm1 = 140;
        //static int x = bpm1;
        //static public int ilosc_sampli = 1;


        //try
        //{
        //    public int x = ;
        //}
        //catch(DivideByZeroException)
        //{
        //    MessageBox.Show("przy tej ilości uderzeń na minutę będę grał ciszę");
        //}
        //Form1.bpm = bpm;
        public int ms = (60000 / 128) / (4);
        public int ms1; 
        
        public int stop = 0;
        public int[] tab;

        

        public string sampel;
        
           
        public int progress=0;
        public int glosnosc=1;
        public static int bpm;

        public void graj()
        {
            
            WaveMixerStream32 mixer = new WaveMixerStream32 { AutoStop = false, };

            IWavePlayer waveOutDevice;
            AudioFileReader audioFileReader;
            //waveOutDevice = new WaveOut();
            waveOutDevice = new WaveOut(WaveCallbackInfo.NewWindow());



                //if (stop_but.Checked) break;

            //Thread thread2 = new Thread(graj);
            //thread2.Start();
            for (int i = 0; i <= 15; i++)//foreach nie zdał tu egzaminu, puszczał dzwiek dwa razy
                {
                if (stop == 1) break;
                    if (tab[i] == 0)
                    {
                        //while(i<=15)
                        //ilosc_sampli = 1;
                        Thread.Sleep(ms);
                        //if (i <= 14) progress++;
                        //if (i == 15) progress = 0;
                    }
                    if (tab[i] == 1)
                {
                        
                        //ilosc_sampli = 1;
                        
                        //if (i <= 14) progress++;
                       // if (i == 15) progress = 0;
                        
                        {
                           // DeviceNumber = 1,
                           // DesiredLatency = 300,
                           // NumberOfBuffers = 3,
                        };
                       // waveOutDevice.Init(mixer);
                        try
                        {
                        AudioFileReader afr = new AudioFileReader(sampel);                            
                        waveOutDevice.Init(afr);
                        waveOutDevice.Play();


                        //int le = waveOutDevice.Play.;
                        //if (waveOutDevice.PlaybackState == PlaybackState.Playing)
                        //{
                        //while (i <= 15)
                            Thread.Sleep(ms);
                        }
                        catch
                        {
                            if(string.IsNullOrEmpty(sampel))
                            {
                                MessageBox.Show("wygląda na to, że zapomniałeś gdzieś wybrać jaki dźwiek mam grać :) wybierz sample klikając przyciski obok siatki, a następnie kliknij stop  ");
                                break;
                            
                            }
                            //else continue;
                        }
                        //if (progressBar1.Value == 15) progressBar1.Value = 0;
                    }
                }
                
            }
        }
       // public int progres = 0;

       /* public void zatrzymaj()
        {
            stop++;
            
        }

        public void pp()
        {

            while (stop != 1)
            {
                for (int i = 0; i <= 15; i++)
                {

                    if (i <= 14) progres++;
                    if (i == 15) progres = 0;
                    Thread.Sleep(ms);
                }
            }

        }
    }*/
}

