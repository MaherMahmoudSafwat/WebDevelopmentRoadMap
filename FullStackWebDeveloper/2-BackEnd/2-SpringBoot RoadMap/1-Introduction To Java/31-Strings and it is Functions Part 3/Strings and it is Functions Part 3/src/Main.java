public class Main {
    public static long IsSquare(long sq)
    {
        int Flag = 1;
        do
        {
            Flag = 1;
            sq++;
            double x = Math.sqrt(sq);
            String y = String.valueOf(x);
            int Decimal = y.indexOf('.');
            for(int i=Decimal+1;i<y.length();i++)
            {
                if(y.charAt(i)!='0')
                {
                        Flag = 2;
                        break;
                }
            }
        }while(Flag == 2);
        return sq;
    }
    public static double countBits(long sq) {
        double x = Math.sqrt(sq);
        String y = String.valueOf(x);
        int Flag = 1;
        int Decimal = y.indexOf('.');
        if (Decimal != -1) {
            for (int i = Decimal + 1; i < y.length(); i++) {
                if (y.charAt(i) != '0') {
                    Flag = 2;
                    break;
                }
            }
            if (Flag == 2)
                return -1;
        }
        return IsSquare(sq);
    }
    public static void main(String[] args)
    {
       System.out.println(countBits(121));
    }
}