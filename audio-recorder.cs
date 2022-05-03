// Test with net6.0 and BASS from https://www.un4seen.com/ to get started with
// cross-platform audio recording


using System;
using System.IO;
using System.Runtime;
using System.Runtime.InteropServices;
using ManagedBass;

namespace HelloBASS
{

    public delegate void DataAvailableHandler(byte[] Buffer, int Length);
  public class AudioRecorder : IDisposable
  {
      int _handle;
      bool Procedure(int Handle, IntPtr Buffer, int Length, IntPtr User)
      {
          if (_buffer == null || _buffer.Length < Length)
              _buffer = new byte[Length];

          Marshal.Copy(Buffer, _buffer, 0, Length);

          DataAvailable?.Invoke(_buffer, Length);

          return true;
      }
      public AudioRecorder()
      {
          Bass.RecordInit();

          _handle = Bass.RecordStart(44100, 2, 0, Procedure);
      }

      byte[] _buffer;
      public event DataAvailableHandler DataAvailable;
      public void Start()
      {
          Bass.ChannelPlay(_handle);
      }

      public void Stop()
      {
          Bass.ChannelStop(_handle);
      }

      public void Dispose()
      {
          Bass.RecordFree();
      }
  }
    class Program
    {

      static AudioRecorder _r;
      static WaveFileWriter _writer;

      void Stop()
      {

        _r?.Dispose();

        _writer?.Dispose();
      }
      static readonly string OutFolder = Environment.GetEnvironmentVariable("HOME");
      static void New()
      {
        var filePath = Path.Combine(OutFolder, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".wav");
        _r = new AudioRecorder();
        try
        {
          _writer = new WaveFileWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read), new WaveFormat());
        }
        catch
        {
          Console.WriteLine("Error");
        }
        _r.DataAvailable += (Buffer, Length) => _writer?.Write(Buffer, Length);
        _r.Start();
      }


        static void Main(string[] args)
        {
          while(true)
          {
            Console.WriteLine("Was eingeben ");
            string hr = Console.ReadLine();
            Console.WriteLine(hr);
            if (hr=="1")
            {
              Console.WriteLine(Path.Combine(OutFolder, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".wav"));
              New();
            } else if (hr=="2")
            {
              _r.Stop();
              _r?.Dispose();
              _writer?.Dispose();
            }
          }




//            // Init BASS using the default output device
//    //        if (Bass.Init())
//    //        {
//                // Create a stream from a file
//                //        Bass.RecordInit();
//                var stream = Bass.CreateStream("test.wav");
//
//                if (stream != 0)
//                    Bass.ChannelPlay(stream); // Play the stream
//
//                // Error creating the stream
//                else Console.WriteLine("Error: {0}!", Bass.LastError);
//
//                // Wait till user presses a key
//                Console.WriteLine("Press any key to exit");
//                Console.ReadKey();
//
//                // Free the stream
//                Bass.StreamFree(stream);
//
//                // Free current device.
//                Bass.Free();
//            }
//            else Console.WriteLine("BASS could not be initialized!");
        }
    }
}
