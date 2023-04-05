using System;
using System.Collections.Generic;

public class Authenticator
{
    // TODO: Implement the Authenticator.Admin property
    public Identity Admin
    {
        get
        {
            var facial = new FacialFeatures();
            facial.EyeColor = "green";
            facial.PhiltrumWidth = .9m;

            var admin = new Identity();
            admin.Email = "admin@ex.ism";
            admin.FacialFeatures = facial;
            admin.NameAndAddress = new List<string>() { "Chanakya", "Mumbai", "India" };

            return admin;
        }
    }

    // TODO: Implement the Authenticator.Developers property
    public IDictionary<string, Identity> Developers
    {
        get
        {
            var bertrandFacial = new FacialFeatures();
            bertrandFacial.EyeColor = "blue";
            bertrandFacial.PhiltrumWidth = .8m;

            var bertrand = new Identity();
            bertrand.Email = "bert@ex.ism";
            bertrand.FacialFeatures = bertrandFacial;
            bertrand.NameAndAddress = new List<string>() {"Bertrand","Paris","France" };

            var andersFacial = new FacialFeatures();
            andersFacial.EyeColor = "brown";
            andersFacial.PhiltrumWidth = .85m;

            var anders = new Identity();
            anders.Email = "anders@ex.ism";
            anders.FacialFeatures = andersFacial;
            anders.NameAndAddress = new List<string>() { "Anders", "Redmond", "USA" };

            return new Dictionary<string, Identity>() { ["Bertrand"] = bertrand, ["Anders"] = anders };
        }
    }
}

//**** please do not modify the FacialFeatures class ****
public class FacialFeatures
{
    public string EyeColor { get; set; }
    public decimal PhiltrumWidth { get; set; }
}

//**** please do not modify the Identity class ****
public class Identity
{
    public string Email { get; set; }
    public FacialFeatures FacialFeatures { get; set; }
    public IList<string> NameAndAddress { get; set; }
}
