public class Email : IContactMethod
{
    // See RFC 6350 Section 6.4.2 Email
    // EMAIL;TYPE=work:jqpublic@xyz.example.com
    // EMAIL;PREF=1:jane_doe@example.com
    public string Uri { get; }
    public string EmailAddress { get; set; }
    public IList<string> Label { get; set; }
    public int Preferred { get; set; }
}