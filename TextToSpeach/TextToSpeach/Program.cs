using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;

//******************************************************
// Author: Rob Hatfield
// Description: This program uses microsoft .net to 
//              convert text to speech
//*****************************************************
namespace TextToSpeach
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SetOutputToDefaultAudioDevice(); 
            foreach (var v in synth.GetInstalledVoices().Select(v => v.VoiceInfo))
            {
                Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
                  v.Description, v.Gender, v.Age);
            }
            synth.SelectVoice("Microsoft Zira Desktop");
            Console.WriteLine("We are using " + synth.Voice.Name);
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak("This is a voice example for Shelby Valley's robotics project!");

        }
    }
}
