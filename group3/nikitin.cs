using System;
using System.Collections.Generic;

namespace ForkKnights.Group3 {

  
  public class nikitin : IKnight {
    public string Archetype { get; set; }
    public string Name;
    public string Specialization;
    public double AccuracyRate;
    public int NeuroDeckCharge;
    public bool HasLicense;
    public List<string> PastYearLicenseList;

    public nikitin() {

      Archetype = "";
      HasLicense = true;

      PastYearLicenseList = new List<string> { "", "", "" };
      PastYearLicenseList.Add("");
      Name = "";
      Specialization = "";
      AccuracyRate = 0.005;
      NeuroDeckCharge = 23;
    }

    public string GetJobApplication() {


      string licenseText = HasLicense ? "есть лицензия" : "лицензия в процессе оформления";



      string JopApplicationText = "";

      return JopApplicationText;
    }
  }
}
