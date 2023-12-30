using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;

namespace UIT_Pokemon
{
    class Information
    {
        public static Size PokemonPieceSize = new Size(CollectionImage.PokemonImage[0, 0].Width, CollectionImage.PokemonImage[0, 0].Height);
        public static Point StartLocation = new Point(100, 125);
        public static int PokemonNumber=16;
        public static int defaultPokemonNumber=19;
        public static int CurrentKindGame = 16;
        public static int sum_height = 18;
        public static int sum_width = 10;
        public static int onePercent = 5;
        public static int timeway = 250;
        public static int timeHelp = 600;
        public static String directories = "";
        public static String fileHighScore="HighScore.dat";
        public static String Gamelog = "GameReport.log";
        public static int Level = 1;
        public static String StringLevel = "LEVEL";
        public static String StringLock = "LOCKED";
        public static String StringUnlock = "UNLOCK";
        public static String StringNext = "NEXT";
        public static String StringPercent = "PERCENT SPARE : ";
        public static String StringRandom = "RANDOM CLICK : ";
        public static String StringHelp = "HELP CLICK :";
        public static String StringSmartEye = "SMART EYE: ";
        public static String StringTotal = "TOTAL : ";
        public static String StringGameover = "GAME OVER !";
        public static String StringPause = "PAUSE !";
        public static String StringFinish = "GAME FINISH, CONGRATULATION ! ";
        public static String StringKindEasy = "Medium (19 Character for first Level )";
        public static String StringKindMedium="Hard (25 Character for first Level )";
        public static String StringKindDifficult = "hardest (31 Character for first Level )";
        public static String StringButtonOK = "OK";
        public static String StringButtonCancel = "Cancel";
        public static String StringKindgameLabel1 = "CHOOSING KIND OF GAME ";
        public static String StringKindgameLabel2 = "Note: Play again if you choose it !";
        public static String StringOptionLabel = "CONFIG FOR UIT-POKEMON GAME";
        public static String StringCollectionPikemon = "THE POKEMON COLLECTION YOU HAVE WON !";
        public static String StringIntroduce = "INTRODUCING ABOUT POKEMON GAME (VERSION 1.0)";
        public static String StringIntroduce1 = "";
        public static String StringIntroduce2 = "";
        public static String StringIntroduceEnd = "";
        public static String Stringruleplay = "RULE TO PLAY AT CURRENT lEVEL ! (LEVEL ";
        public static String StringSound = "Turn on sound";
        public static String StringEffect = "Turn on Menu effect ";
        public static String StringFull = "Turn on Full Screen";
        public static String StringChangeColor = "Change Skin Way";
        public static String StringIntroducegame = "Introduce about game";
        public static String StringChaneLanguage = "Change Language";
        public static String StringRulePlay = "Rule play";

        //public static String StringCongratulation = "CONGRATULATION !";
        public static ImageFile imageFileLevel = new ImageFile(null,1);
        public static bool LockNextButton = false;
        public static void  Vietnamese()
        {
            StringLevel = "VÒNG";
            StringLock = "  KHÓA !";
            StringUnlock = "MỞ KHÓA";
            StringNext = "TIẾP TỤC";
            StringPercent = "THỜI GIAN DƯ : ";
            StringRandom = "ĐẢO NGẨU NHIÊN : ";
            StringHelp = "GIÚP ĐỞ :";
            StringSmartEye = "TINH MẮT: ";
            StringTotal = "TỔNG CỘNG : ";
            StringGameover = "KẾT THÚC !";
            StringPause = "TẠM DỪNG !";
            StringFinish = " TRÒ CHƠI HOÀN THÀNH, XIN CHÚC MỪNG !";
            StringKindEasy = "Trung bình ( 19 Nhân vật ở vòng đầu tiên )";
            StringKindMedium = "khó ( 25 Nhân vật ở vòng đầu tiên )";
            StringKindDifficult = "khó nhất ( 31 Nhân vật ở vòng đầu tiên )";
            StringButtonOK = "Đồng ý";
            StringButtonCancel = "Thoát";
            StringKindgameLabel1 = "Lựa chọn loại trò chơi ";
            StringKindgameLabel2 = "Cảnh báo : Sẽ chơi lại từ đầu nếu bạn Đồng ý";
            StringOptionLabel = "CÀI ĐẶT CẤU HÌNH CHO GAME UIT-POKÉMON";
            StringCollectionPikemon = "BỘ SƯU TẬP POKÉMON BẠN ĐÃ CHINH PHỤC !";
            StringIntroduce = "GIỚI THIỆU VỀ TRÒ CHƠI UIT-POKÉMON (PHIÊN BẢN 1.0)";
            Stringruleplay = "LUẬT CHƠI Ở VÒNG HIỆN TẠI (VÒNG ";
            StringSound = "bật âm thanh";
            StringEffect = "bật hiệu ứng Menu ";
            StringChangeColor = "Đổi màu đường đi";
            StringChaneLanguage = "Thay đổi Ngôn ngữ ";
            StringFull = "Bật chế độ toàn màn hình";
            StringIntroduce1="UIT-Pokemon version 1.0 được viết bằng ngôn ngữ lập trình MS Visual C#, gồm 15 Vòng, trong đó mỗi vòng chơi có một luật chơi khác nhau. Sau khi hoàn thành một vòng chơi sẽ có một Pokemon được mở khóa, Các Pokemon được mở khóa này sẽ được xuất hiện ở các vòng tiếp theo.\nTrò chơi có 3 cấp độ là :";
            StringIntroduce2 = "- Loại thông thường: gồm có 19 Pokemon xuất hiện trong vòng đầu tiên, tối đa là 33\n\n- Loại Khó: gồm có 25 Pokemon xuất hiện trong vòng đầu tiên, tối đa là 39\n\n- Loại Siêu Khó:(thể loại thách thức trí nhớ) gồm có 31 Pokemon xuất hiện trong vòng đầu tiên, tối đa là 45";
            StringIntroduceEnd = "HÃY CÙNG NHAU ĐI TÌM POKÉMON VÔ ĐỊCH !!!";
            StringIntroducegame = "Giới thiệu về trò chơi";
            StringRulePlay = "Luật chơi";
        }
        public static void English()
        {
            StringLevel = "LEVEL";
            StringLock = "LOCKED";
            StringUnlock = "UNLOCK";
            StringNext = "NEXT";
            StringPercent = "PERCENT SPARE : ";
            StringRandom = "RANDOM CLICK : ";
            StringHelp = "HELP CLICK :";
            StringSmartEye = "SMART EYE: ";
            StringTotal = "TOTAL : ";
            StringGameover = "GAME OVER !";
            StringPause = "PAUSE !";
            StringFinish = "GAME FINISH, CONGRATULATION ! ";
            StringKindEasy = "Easy (19 Character for first Level )";
            StringKindMedium = "Medium (25 Character for first Level )";
            StringKindDifficult = "Difficult (31 Character for first Level )";
            StringButtonOK = "OK";
            StringButtonCancel = "Cancel";
            StringKindgameLabel1 = "CHOOSING KIND OF GAME ";
            StringKindgameLabel2 = "Note: Play again if you choose it !";
            StringOptionLabel = "CONFIG FOR UIT-POKEMON GAME";
            StringCollectionPikemon = "THE POKEMON COLLECTION YOU HAVE WON !";
            StringIntroduce = "INTRODUCING ABOUT POKEMON GAME (VERSION 1.0)";
            Stringruleplay = "RULE TO PLAY AT CURRENT lEVEL (LEVEL ";
            StringSound = "Turn on sound";
            StringEffect = "Turn on Menu effect ";
            StringChangeColor = "Change Skin Way";
            StringChaneLanguage = "Change Language";
            StringIntroducegame = "Introduce about game";
            StringRulePlay = "Rule play";
        }
    }
}
