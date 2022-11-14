using Microsoft.Extensions.Options;
using MVPParteSofi.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.App.DownloadManager;
using static Android.Provider.Telephony;
using static Android.Views.WindowInsets;

namespace MVPParteSofi.MVVM.ViewModels
{
    public class CargarFrecuenciaViewModel
    {   
        public FrecuenciaData FrecuenciaData_ { get; set; } = new FrecuenciaData
        {
            DiaFrecuencia= DateTime.Now
            
        };
        public async void GuardarFrecuencia()
        {
    
            if(FrecuenciaData_.ValorFrecuencia < 30) //valor erróneo
            {
                await Application.Current.MainPage.DisplayAlert("Por favor, ingrese un valor correcto", null, "Aceptar");

            }
            else if (FrecuenciaData_.ValorFrecuencia > 250) //valor erróneo
            {
                await Application.Current.MainPage.DisplayAlert("Por favor, ingrese un valor correcto", null, "Aceptar");

            }
            else if (FrecuenciaData_.ValorFrecuencia < 50) //valor malo
            {
                await Application.Current.MainPage.DisplayAlert("Su valor ha sido registrado", "El valor ingresado se encuentra fuera del rango normal de frecuencia cardíaca. \r\n\r\nLe recomendamos volver a tomar la medición en 5 minutos, recuerde seguir los pasos dentro del tutorial para obtener un resultado adecuado.\r\n\r\nAnte una urgencia, por favor diríjase al centro de salud más cercano.\r\n\r\nEn caso haber esperado el tiempo recomendado para realizar la segunda medición y la misma persiste en un valor fuera del rango normal, se aconseja acercarse al centro de salud más cercano o contáctese con su médico.", "Aceptar");

            }
            else if (FrecuenciaData_.ValorFrecuencia > 110) //valor malo
            {
                await Application.Current.MainPage.DisplayAlert("Su valor ha sido registrado", "El valor ingresado se encuentra fuera del rango normal de frecuencia cardíaca.\r\n\r\n Le recomendamos volver a tomar la medición en 5 minutos, recuerde seguir los pasos dentro del tutorial para obtener un resultado adecuado.\r\n\r\nAnte una urgencia, por favor diríjase al centro de salud más cercano.\r\n\r\nEn caso haber esperado el tiempo recomendado para realizar la segunda medición y la misma persiste en un valor fuera del rango normal, se aconseja acercarse al centro de salud más cercano o contáctese con su médico.", "Aceptar");
            }
            else if (FrecuenciaData_.ValorFrecuencia < 60) //valor más o menos
            {
                await Application.Current.MainPage.DisplayAlert("Su valor ha sido registrado", "El valor ingresado se encuentra levemente fuera del rango normal de frecuencia cardíaca.\r\n\r\nLe recomendamos volver a tomar la medición en 15 minutos, recuerde seguir los pasos dentro del tutorial para obtener un resultado adecuado.\r\n\r\nEn caso haber esperado el tiempo recomendado para realizar la segunda medición y la misma persiste en un valor fuera del rango normal, se aconseja acercarse al centro de salud más cercano o contáctese con su médico.", "Aceptar");

            }
            else if (FrecuenciaData_.ValorFrecuencia > 100) //valor más o menos
            {
                await Application.Current.MainPage.DisplayAlert("Su valor ha sido registrado", "El valor ingresado se encuentra levemente fuera del rango normal de frecuencia cardíaca. \r\n\r\nLe recomendamos volver a tomar la medición en 15 minutos, recuerde seguir los pasos dentro del tutorial para obtener un resultado adecuado.\r\n\r\nEn caso haber esperado el tiempo recomendado para realizar la segunda medición y la misma persiste en un valor fuera del rango normal, se aconseja acercarse al centro de salud más cercano o contáctese con su médico.", "Aceptar");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Su valor ha sido registrado", null, "Aceptar", "Volver");
                App.FrecuenciaRepo.SaveItem(FrecuenciaData_);
            }
        }
    }
}

