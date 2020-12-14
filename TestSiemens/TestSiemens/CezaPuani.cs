using System;
namespace TestSiemens
{
    public class CezaPuani
    {
        private const int HizLimit = 65;
        private const int HizUstLimit = 300;

        public int CezaPuaniHesaplama(int hiz)
        {
            if (hiz < 0 || hiz > HizUstLimit)
                throw new ArgumentOutOfRangeException();

            if (hiz <= HizLimit) return 0;

            const int KmIcinCezaPuani = 5;
            var cezaPuani = (hiz - HizLimit) / KmIcinCezaPuani;
                            
            return cezaPuani;
        }
    }
}
