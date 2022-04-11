// See https://aka.ms/new-console-template for more information

Console.WriteLine("Kreska dopasowujaca sie do ekranu\n");

Change_Width(Console.WindowWidth);



static void Change_Width(int winWidth)
{
    Line(winWidth);


    while (true)
    {

        int delta_width = Console.WindowWidth - winWidth;
        if (delta_width > 0)

        {
            winWidth= Console.WindowWidth;

            Line(delta_width);


        }
        else if (delta_width < 0)
        {
            winWidth = Console.WindowWidth;
            LineMinus(delta_width);



        }

    }

}

static void Line(int delta)
{

    for (int i = 0; i < delta; i++)
    {
        Console.Write("-");
    }


}

static void LineMinus(int delta)
{

    for (int i = delta; i < 0; i++)
    {
        Console.Write("\b \b");
    }


}
Console.Write("\n");