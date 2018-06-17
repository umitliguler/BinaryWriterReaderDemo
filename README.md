# BinaryWriterReaderDemo
BinaryReader ve BinaryWriter sınıfları ile binary formatındaki dosyalar üzerinde işlemler yapabiliriz.


Directory.CreateDirectory(@"C:\WINDOWS\deneme");
Bu kod C:\WINDOWS altında deneme isimli bir klasör oluşturur.

Directory.CreateDirectory("deneme");
Bu kod programın çalıştığı klasörde deneme isimli bir klasör oluşturur.

Directory.CreateDirectory(@"..\deneme");
Bu kod programın çalıştığı klasörün bir üst klasöründe deneme isimli bir klasör oluşturur.

Directory.CreateDirectory(@"..\..\deneme");
Bu kod programın çalıştığı klasörün iki üst klasöründe deneme isimli bir klasör oluşturur. .. sayıları bu şekilde artırılabilir. Bu tür bir adres belirtme şekli bütün diğer metotlarda da geçerlidir. 
Ayrıca bu ve diğer bütün metotlarda da adres diye tarif ettiğimiz veriye dosya/klasörün adı da dâhildir.
