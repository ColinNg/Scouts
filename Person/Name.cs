public class Name
{
    // see RFC 6340 Section 6.2.1 "FN"
    public string FormattedName { get; }
    
    // see RFC 6350 Section 6.2.2 "N"
    public string FamilyNames { get; set; }
    public string GivenNames { get; set; }
    public string AdditionalNames { get; set; }
    public string HonorificPrefixes { get; set; }
    public string HonorificSuffixes { get; set; }
    
    // N:Stevenson;John;Philip,Paul;Dr.;Jr.,M.D.,A.C.P.

    // Not sure what to do when people have two names - such as in Kanji and an anglicised one

}