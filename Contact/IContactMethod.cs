interface IContactMethod
{
    string Uri { get; set; }
    // i.e. Home, Work, etc.
    IList<string> Labels { get; set; }
    int Preferred { get; set; }
}