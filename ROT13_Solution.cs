using System;

public class Kata
{
  public static string Rot13(string input)
  {
    char[] wordArray = input.ToCharArray();
    
    for(int i=0;i<input.Length;i++){
      if((wordArray[i]>='a' && wordArray[i]+13<='z') || (wordArray[i]>='A' && wordArray[i]+13<='Z'))
      wordArray[i]=(char)((int)(wordArray[i]) + 13);
         else if((wordArray[i]>='a' && wordArray[i]<='z')||wordArray[i]>='A' && wordArray[i]<='Z'){
      for(int j=0;j<13;j++){
        if(wordArray[i]=='z'){
          wordArray[i]='a';
        }else if(wordArray[i]=='Z'){
          wordArray[i]='A';
        }else{
          wordArray[i]=(char)((int)(wordArray[i]) +1);
        }
        }
      }
    }
    
    string result = new string(wordArray);
    
    return result;
  }
}
