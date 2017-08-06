public enum TelephoneType
{
    // See RDC 6350 Section 6.4.1 Tel
    Text = 1,   // Indicates that the telephone number supports text messages (SMS). 
    Voice = 2,  // Indicates a voice telephone number. 
    Fax = 3,    // Indicates a facsimile telephone number. 
    Cell = 4,   // Indicates a cellular or mobile telephone number. 
    Video = 5,  // Indicates a video conferencing telephone number. 
    Pager = 6,  // Indicates a paging device telephone number. 
    Textphone = 7,  // Indicates a telecommunication device for people with hearing or speech difficulties. 
    IANAToken = 8,  
    XName = 9,  
}

public class Telephone : IContactMethod
{
    // TEL;VALUE=uri;PREF=1;TYPE="voice,home":tel:+1-555-555-5555;ext=5555
    // TEL;VALUE=uri;TYPE=home:tel:+33-01-23-45-67
    public string Uri { get; }
    public string Number { get; set; }
    public IList<TelephoneType> TelephoneTypes { get; set; }
    public IList<string> Labels { get; set; }
}
