using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTest1.Models
{
    public class Citizen
    {
        public Guid CitizenId { get; set; }
        public string DBRNumber { get; set; }
        public string CitizenName { get; set; }
        public string Gender { get; set; }
        public string BirthType { get; set; } // طبيعي او قيصري
        public string NumberOfBorn { get; set; } //   مفرد توام او ثلاثي
        public DateTime BOD { get; set; }
        public string BODText { get; set; }

        public string FatherName { get; set; }
        public string FatherAge { get; set; }
        public string FatherWork { get; set; }
        public string MotherName { get; set; }
        // Cascade Birth location
        public string City { get; set; }  // المدينة
        public string Side { get; set; } //  الناحية
        public string Eliminate { get; set; }  //  القضاء
        public string Governorate { get; set; }  //  المحافظة
        public string DepartmentOfHealth { get; set; } // دائر الصحة المتوفرة
        public string QRCode { get; set; }



        // users
        ///     مستشفى حكومية  - شعبة احصاء - مكتب تسجيل ولادات - ثم للدائرة والموافقة
        ///     كل مشفى له مستخدم واحد في شغبة الاحصاء وواحد مكتب تسجيل وتدقيق وواحد موافقات ثم بعد موافقه اذهب للاحوال
        ///     وتصدير مع كيو ار كود

    }
}
