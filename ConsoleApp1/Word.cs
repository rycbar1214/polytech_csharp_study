namespace ConsoleApp1;
//i번째 글자가 모음인지 알려주는 isVowel() 메서드

public class Word
{
    private string word = "retry";

    public bool IsVowel(int i)
    {
        //word[i]가 'a'와 같은지 확인
        if (i < 0 || i >= word.Length)
        {
            return false;
        }
        char c=char.ToLower(word[i]);
        string vowel = "aeiou";
        return vowel.Contains(c);
    }
    
    //i번째 글자가 자음인지 알려주는 IsConsonant() 함수 수정

    public bool IsConsonant(int i)
    {
        if(i<0||i>=word.Length) throw new System.ArgumentOutOfRangeException(nameof(i));
        char c = word[i];
        if (!char.IsLetter(c)) return false;
        return !IsVowel(i);
    }
}