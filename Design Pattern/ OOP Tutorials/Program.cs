// Strategy Pattern

using OOP_Tutorials.Design_Patterns.Behavioural.Strategy;

var VideoStorage = new VideoStorage(new CompressorMOV(), new BWOverlay());
VideoStorage.Store("/video/movie");

VideoStorage.SetCompressor(new CompressorMP4());
VideoStorage.SetOverlay(new NoOverlay());

VideoStorage.Store("/video/movie");

