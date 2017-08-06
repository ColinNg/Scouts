// I'm thinking that biological gender is really none of our business, so maybe we should not make that distinction. 
// An issue may arise in fulfilling Police Record Checks or providing information to authorities - what to do if gender identity has changed? 

public class Gender
{
    public Sex Sex { get; set; }
    public string GenderIdentity { get; set; }
}

public enum Sex
{
    "" = 0,
    M = 1,
    F = 2,
    O = 3,
    N = 4,
    U = 5,
}
