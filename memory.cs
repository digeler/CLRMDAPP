using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Diagnostics.Runtime;
using clrmdapp;
using System.Windows.Forms;


namespace clrmdapp
{
    public static class Memory
    {

        public static ClrRuntime Createruntime(string dac, string dump)
        {


            // Create the data target.  This tells us the versions of CLR loaded in the target process.
            DataTarget dataTarget = DataTarget.LoadCrashDump(dump);

            // Now check bitness of our program/target:
            //bool isTarget64Bit = dataTarget.PointerSize == 8;
            //if (Environment.Is64BitProcess != isTarget64Bit)
            //{
            //    // f.resultobox.Text = throw new Exception(string.Format("Architecture mismatch:  Process is {0} but target is {1}", Environment.Is64BitProcess ? "64 bit" : "32 bit", isTarget64Bit ? "64 bit" : "32 bit"));
            //    MessageBox.Show(string.Format("Architecture mismatch:  Process is {0} but target is {1},Please check your setting and try again ,Ok will restart the app", Environment.Is64BitProcess ? "64 bit" : "32 bit", isTarget64Bit ? "64 bit" : "32 bit"));
            //    // Note I just take the first version of CLR in the process.  You can loop over every loaded
            //    // CLR to handle the SxS case where both v2 and v4 are loaded in the process.
            //    //System.Diagnostics.Process.Start(Application.ExecutablePath);

            //}
            ClrInfo runtimeInfo = dataTarget.ClrVersions[0];

            foreach (ClrInfo version in dataTarget.ClrVersions)
            {



                //Console.WriteLine("Found CLR Version: " + version);
                Form1. r = new Form1();
                
                
                
                    r.resultobox.Clear();
                    r.resultobox.up("Found CLR Version: " + version);
                
                r.Dispose();
                // This is the data needed to request the dac from the symbol server:
                //ModuleInfo dacInfo = version.DacInfo;
                //Console.WriteLine("Filesize:  {0:X}", dacInfo.FileSize);
                //Console.WriteLine("Timestamp: {0:X}", dacInfo.TimeStamp);
                //Console.WriteLine("Dac File:  {0}", dacInfo.FileName);



               


            }
            return runtimeInfo.CreateRuntime(dac);
        }




    }
}
