internal class Program

{
    private static void Main(string[] args)

    {
        // sıra geldi tanımlanmış class dan bir örnek-instance-nesne yaratmaya
        // <sınıf adı> <nesne adı> = new < sınıf adı>


        CarGallery carGallery = new CarGallery(); //nesnem tanımlanmış olan sınıftan kendini örnekledi.--> (instance aldı... bellekte nesne yaratıldı.)

        // nesnemizin özelliklerine ulaşalım

        carGallery.Brand = "Mercedes "; // bellekte boş olan yerleri veri ile dolduruldu.

        carGallery.Model = "C200";

        carGallery.Color = "Fume";

        Console.WriteLine(carGallery.Brand + " - " + carGallery.Model + " Rengi " + carGallery.Color);
        Console.WriteLine(carGallery.Price.ToString()); // fiyatını da sınıf içinde default olarak tanımlanmış propertiy den ( özellikten) alacak

        Console.ReadKey();












    }



    // Benim bir araba galerim var. Galerimde arabalar var
    // dolayısı ile ilk önce içinde verileri tutacak tanımlayacağım.
    // syntax : < erişim belirleyeici > class < sınıfın adı >



    public class CarGallery  // public erişim belirleyicisi, CarGallery isminde bir class tanımlanıyor.

    {
        public string Brand { get; set; } // marka

        public string Model { get; set; } // model

        public string MClass { get; set; } // sınıf (B,C,D)

        public int MPower { get; set; } // motor gücü (90,140 beygir..)

        public int MVolume { get; set; } // 1400,  2000 cc

        public int MSerial { get; set; } // motor seri no (xkdjfoıwrj)

        public char GasType { get; set; } // yakıt türü

        public char GearType { get; set; } // vites türü

        public string CaseType { get; set; } // Kasa tipi

        public int ProducedYear { get; set; } // üretim yılı

        public string Color { get; set; } // renk bilgisi

        public int Price = 100000; // default bir değer atandı  

        // get; bellekte duranı getir set; bellekte duranı değiştir


    }




}

