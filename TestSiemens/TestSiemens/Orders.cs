using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSiemens
{
    public class Orders
    {
        //.com , .net ....
        // TLD => Top Level of Domain
        List<string> domains = new List<string> { ".com", ".net", ".org" };

        public bool CheckOrderAmountAndGiveVoucherCode
            (int amount, string email)
        {
            /*
             * girilen verinin tipi listi kullanacak olan 
             * yazilimci tarafindan kontrol edilmez ise run time da
             * exception firlatir.
                ArrayList list = new ArrayList();
                list.Add(1);
                list.Add("Omur");
                list[0] == "omur";
            */

            //omur.ucum@bilgeadam.com
            var checkPoint = email.LastIndexOf('.');
            var tld = email.Substring(checkPoint, 4);

            //Bu kismi daha sonra https://www.abstractapi.com/
            //sitesine baglanarak canli bir sekilde test edecegiz.
            if (!domains.Contains(tld))
                throw new Exception();

            if (amount < 0)
                throw new ArgumentOutOfRangeException();


            if (!email.Contains('@'))
                throw new ArgumentException();

            //fiyat kontrolu baska ne sekil de yapabilir?
            if (amount > 249 && amount < 501)
            {
                var discountAmount = amount * 0.10;
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var rnd = new Random();
                //Bu sekilde bir voucher uretimi pek saglikli 
                //olmayabilir. Calisma zamani uzun surebilir.
                //CPU ya da I/O tuketen kodlar cloud sunucularda (ozellikle)
                //ek maliyetlere sebep olabilir.

                //var voucherCode = new string(
                //            Enumerable.Repeat(chars, 6)
                //            .Select(s => s[rnd.Next(s.Length)])
                //            .ToArray()
                //        );

                //Guid ile olusturulan
                var voucherCode = GenerateVoucherCode(6, chars.ToCharArray());

                Console.WriteLine("Tebrikler {0} TL tutarinda indirim" +
                    "kazandiniz. Kupon Kodunuz : {1}", discountAmount, voucherCode); ;
            }

            //if(Enumerable.Range(250,500).Contains(amount))
            //{

            //}
            return false;

        }

        public string GenerateVoucherCode(int length, char[] chars)
        {
            var voucher = chars.OrderBy(o => Guid.NewGuid()).Take(length);

            return new string(voucher.ToArray());
        }

    }
}
