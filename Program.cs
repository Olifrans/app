

// https://disco-agustinia-197.notion.site/Laborat-rio-Azure-Fala-para-texto-b0a1b8cd4bea43ba9bb3793bc11754a5
// https://disco-agustinia-197.notion.site/Laborat-rio-Azure-Fala-para-Texto-EX-33179a5fc64e4ddfa7b0ceaf51832647


using System;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;


Console.WriteLine("Laboratório Fala para texto");
var config = SpeechConfig.FromSubscription("CxLoPRYs5IlAfJyeCbxnS1EGWCbF5Eg8Lb34lWOXmr46LzDYNA2lJQQJ99AJACYeBjFXJ3w3AAAYACOGxwrE", "eastus");
var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
var recognizer = new SpeechRecognizer(config, "pt-BR", audioConfig);
Console.WriteLine("Pronto para começar....");

while (true)
{

    var result = await recognizer.RecognizeOnceAsync();
    var text = result.Text;
    Console.WriteLine($"Rec: {text}");
    if (text.ToLower().Contains("sair."))
    {
        break;
    }
}
Console.ReadKey();



// using System;
// using Microsoft.CognitiveServices.Speech;
// using Microsoft.CognitiveServices.Speech.Audio;


// Console.WriteLine("Laboratório Fala para texto");
// var config = SpeechConfig.FromSubscription("CxLoPRYs5IlAfJyeCbxnS1EGWCbF5Eg8Lb34lWOXmr46LzDYNA2lJQQJ99AJACYeBjFXJ3w3AAAYACOGxwrE", "eastus");
// var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
// var recognizer = new SpeechRecognizer(config, "pt-BR", audioConfig);
// Console.WriteLine("Pronto para começar");

// var result = await recognizer.RecognizeOnceAsync();
// var text = result.Text;
// Console.WriteLine($"Rec: {text}");

// Console.ReadKey();cd