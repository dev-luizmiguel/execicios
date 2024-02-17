// Desafio 01
using System.Net.Http.Headers;

float tempo_viagem=2f;
float vl_media=92f;
double  media=(vl_media*tempo_viagem)/12f;
media = Math.Round(media,3);
System.Console.WriteLine(media);