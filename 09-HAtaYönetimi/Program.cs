/*
  Istisna Tipleri

1- Derleme Zamanı (Compile Exception): Genellikle syntax kaynaklı (yazılımsal hatalar) hatalardır. Hata meydana geldiğinde Visual Studio bize bilgi verir.
2-Çalışma Zamanı (Runtime Exception): Çoğunlukla kullanıcı kaynaklı (verinin yanlış veya eksik girilmesi gibi) hatalardır.Çözüm: Try-catch mekanizması.
3- Mantıksal Hatalar: Yüzde yüz yazılımcı kaynaklı hatalardır. Uygulamanın algoritmasından kaynaklanır. Çözülmeis en zor hata tipidir.
 */

/*
try{
    // çalışmasını istediğim kodları buraya yazarım. 
}
catch{
    // try içerisindeki kodlar çalıştırıldığında bir hata oluşursa buradaki kodlar çalışır.
}
 */

#region Ornek1 
//try
//{
//    Console.WriteLine("Telefon Numarası:");
//    int gelenDeger = Convert.ToInt32(Console.ReadLine());
//    // System.OverflowException: 'Value was either too large or too small for an Int32.'

//    Console.WriteLine("Tebrikler! Doğru Telefon Numarası Girdiniz.");
//}
//catch 
//{
//    Console.WriteLine("Telefon numarası yazmayı bile beceremedin!");
//}

#endregion

#region Ornek2 
//try
//{
//    Console.WriteLine("Telefon Numarası:");
//    int gelenDeger = Convert.ToInt32(Console.ReadLine());
//    // System.OverflowException: 'Value was either too large or too small for an Int32.'

//    Console.WriteLine("Tebrikler! Doğru Telefon Numarası Girdiniz.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion

#region Ornek3 
//string gelenDeger = null;
//try
//{
//    Console.WriteLine("Telefon Numarası: (XXX-XXX-XX-XX)");
//    gelenDeger = Console.ReadLine();

//    throw new Exception("Doğru Formatta Girmedin"); // Bilinçli bir şekilde hata fırlatma.

//    Console.WriteLine("Tebrikler!");
//}
//catch (Exception hata)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine($"Error: {hata.Message}");
//    Console.ForegroundColor = ConsoleColor.White;    
//}
//finally
//{
//    // Hata olsa da olmasa da çalışmasını istediğimiz kodları yazdığımız alandır.
//    Console.WriteLine("Hata var mı? yok mu? beni ilgilendirmez, ben işimi yaparım.");
//}

//Console.WriteLine(gelenDeger);

#endregion

#region Ornek4

try
{
    Console.WriteLine("Telefon Numarası : ");
    int gelenDeger = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Tebrikler! Doğru Telefon numarası girdiniz.");
}
catch (FormatException ex) // Format hata tipi String to Int
{
    Console.WriteLine(ex.Message);
}
catch (OverflowException ex) // Veri tipinin boyutunu aşması durumunda hata tipi.
{
    Console.WriteLine($"{ex.Message}");
}
catch(DivideByZeroException ex) 
{
    Console.WriteLine($"{ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
} 

#endregion