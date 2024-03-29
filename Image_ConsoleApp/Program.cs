﻿
// This file was auto-generated by ML.NET Model Builder. 

using Image_ConsoleApp;
using System.IO;

// Create single instance of sample data from first line of dataset for model input
var imageBytes = File.ReadAllBytes(@"C:\Users\jbursi\source\repos\EmergingSoftProj\Library Page\Project Images\Cat Images\Cat 1.jpg");
MyMachineLearning.ModelInput sampleData = new MyMachineLearning.ModelInput()
{
    ImageSource = imageBytes,
};

// Make a single prediction on the sample data and print results.
var sortedScoresWithLabel = MyMachineLearning.PredictAllLabels(sampleData);
Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");

foreach (var score in sortedScoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
}
