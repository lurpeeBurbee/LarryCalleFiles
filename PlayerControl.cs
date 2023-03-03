bool winGame = false;
bool gameOver = false;

int randomMinNumber;
int randomMaxNumber;
int randomNumber;


void Update()
{
    if(Input.GetKey(KeyCode.Space))
    {
        King();
    }
}
void King()
{
    randomMaxNumber = 10;
    randomMinNumber = 0;

    randomNumber = RandomRange(randomMinNumber, randomMaxNumber);


    if (randomNumber => 8)
    {
        Debug.Log("Lauri is a KING!");
        winGame = true;
    }
    else gameOver = true;
}