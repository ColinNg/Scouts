// Stub classes that allow us to continue writing other parts of the system until we replace these with something well-done (i.e. maybe vCard fields are a better way to go?)

public class Identification
{
    public IList<Name> Names { get; set; }
    
    // see RFC 6350 Section 6.2.3 "Nickname"
    public string Nicknames { get; set; }
    
    public Date Birthday { get; set; }
    
    public Gender Gender { get; set; }
    
}