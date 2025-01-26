import java.lang.String
class Generator {
    public static String nickname (String name)
    {
        if(name.length() < 4)
            return "Name too short";
        String NewName = "";
        for(int i=0;i<name.length();i++)
        {
            if((i==2) && (name[i]=='a'||name[i]=='e'||name[i]=='i'||name[i]=='o'||name[i]'u'))
            {
                NewString+=name[i];
                NewString+=name[i+1];
                break;
            }
          else
            {
                NewString+=name[i];
                break;
            }
        }
        return NewString;
    }
}