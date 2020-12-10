using System;
namespace TestSiemens
{
    public class ErrorLogger
    {
        private string LastError { get; set; }
        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            //if(error == null || error.Trim() == "")

            //Asagidaki kod ile yukardaki arasinda bir temel de bir fark
            //yoktur. Sadece kod okunabilirligi ve karsilasilabielcek
            //hata oranini azaltmak amaci ile asagidaki yapi tercih
            //edilmelidir.

            if (String.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();


            LastError = error;

            ErrorLogged?.Invoke(this, Guid.NewGuid());


        }
    }
}
