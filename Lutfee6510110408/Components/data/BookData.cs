public static class BookData
{
    private static List<Book> books = new List<Book>
    {
        new Book {
            Id = 1,
            Title = "Naruto",
            Author = "Masashi Kishimoto",
            Description = "เป็นการ์ตูนนินจาที่ทั้งความสนุกและเความเศร้าภายในตัว",
            Year = 1999,
            Price = 59,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/th/0/03/Naruto_Poster_Shonen_Jumps.jpg"
        },
        new Book {
            Id = 2,
            Title = "One Piece",
            Author = "Eiichiro Oda",
            Description = "เป็นเรื่องราวในยุคทองของโจรสลัด โจรสลัดทุกคนมีเป้าหมายเดียวกันคือเพื่อค้นหา สมบัติในตำนานที่เรียกว่า'วันพีซ'",
            Year = 1997,
            Price = 49,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/th/a/ab/One_Piece%2C_volume_1_thai_version.jpg"
        },
        new Book {
            Id = 3,
            Title = "Dragon Ball",
            Author = "Akira Toriyama",
            Description = "กาลครั้งหนึ่ง มีลิงน้อยจอมพลังชื่อ ซุนโกคู ท่านปู่ ซุนโกฮัง ของเขาเป็นจอมยุทธผู้สันโดษหลีกลี้มาอยู่ในป่าได้ฝึกวิชายุทธให้โกคูให้พอเอาตัวรอด",
            Year = 1984, 
            Price = 49,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/th/9/98/Dragon_Ball_Super%2C_volume_1_thai_version.jpg"
        },
        new Book {
            Id = 4,
            Title = "Attack on Titan",
            Author = "Hajime Isayama",
            Description = "เอเรน เยเกอร์ เด็กหนุ่มที่ต้องเสียแม่ไปจากเหตุการณ์ไททันบุกเข้าทำลายวอลล์มาเรียในเขตชิกันชินา เพราะต้องการแก้แค้นให้กับแม่ของ เอเรน",
            Year = 2009,
            Price = 49,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/th/3/32/Attack_on_Titan%2C_volume_1_thai_version.jpg"
        },
        new Book {
            Id = 5,
            Title = "My Hero Academia",
            Author = "Kohei Horikoshi",
            Description = "มิโดริยะ อิซึคุ เป็นเด็กมัธยมต้นธรรมดาคนหนึ่งที่อยู่ในโลกของผู้คนที่ไม่ธรรมดา เพราะว่าโลกที่เขาอยู่นั้น 80% ของมนุษย์ล้วนมี 'อัตลักษณ์' ",
            Year = 2014,
            Price = 59,
            ImageUrl = "https://m.media-amazon.com/images/I/81AjnD8nvHL._AC_UF1000,1000_QL80_.jpg"
        },
        new Book {
            Id = 6,
            Title = "One-Punch Man",
            Author = "ONE",
            Description = "บนโลกเหนือสิ่งมหัศจรรย์สัตว์ประหลาดและอสูรร้ายได้สร้างความหายนะในเมืองต่างๆ เพื่อต่อสู้ต่อกรกับพวกมัน จึงได้มีการก่อตั้งสมาคมฮีโร่เพื่อหยุดยั้งพวกเขา",
            Year = 2015,
            Price = 59,
            ImageUrl = "https://upload.wikimedia.org/wikipedia/th/3/34/One_Punch.png"
        },
    };

    public static List<Book> GetBooks()
    {
        return books;
    }


}
