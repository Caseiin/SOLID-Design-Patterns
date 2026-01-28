using System;
using System.Runtime.CompilerServices;

namespace OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

public class VideoStorage
{
    ICompressor _compressor;
    IOverlay _overlay;


    public VideoStorage(ICompressor compressor,IOverlay overlay)
    {
        _compressor = compressor;
        _overlay = overlay;
    }


    public void SetCompressor(ICompressor compressor)
    {
        _compressor = compressor;
    }

    public void SetOverlay(IOverlay overlay)
    {
        _overlay = overlay;
    }

    public void Store(string fileName)
    {
        _compressor.Compress();
        _overlay.ApplyOverlay();

        System.Console.WriteLine($"Storing video to {fileName}.{_compressor}");

    }
}
