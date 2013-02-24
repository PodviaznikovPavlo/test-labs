package lab1;

import java.io.Console;
import java.util.ArrayList;
import java.util.List;


public class SolveClass {

	/**
	 * @param args
	 */
	
	static List<Integer> perfectNumber = new ArrayList<Integer>();
        static final int bound = 3000; 
	public static int Sum(int naturalNumber)
	{
		int sum=0;
		for(int i=1; i<=naturalNumber/2; i++)
		{
			if(naturalNumber%i==0)
				sum+=i;
		}
		return sum;
	}
        
        public boolean isPerfect(int number)
        {
            boolean var=false;
            for(int i=0; i<perfectNumber.size();i++)
            {
                if(perfectNumber.get(i)==number)
                {
                    var=true;
                    break;
                } 
            }
           return var;
        }
	public void Solver() {
		for(int i=1; i<=bound; i++)
		{
			if(i==Sum(i))
				perfectNumber.add(i);
		}
	}
}
