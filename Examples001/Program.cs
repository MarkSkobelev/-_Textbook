int NumberOfLegs (string animalName)
{
    if (animalName == "слон")
    {
        return 4;
    }
    else if (animalName == "индейка")
    {
        return 2;
    }
    else if (animalName == "устрица")
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
int i;
i = NumberOfLegs("индейка");
Console.WriteLine("У индейки конечностей - " + i);
i = NumberOfLegs("слон");
Console.WriteLine("У слона конечностей - " + i);
i = NumberOfLegs("устрица");
Console.WriteLine("У устрицы конечностей- " + i);
i = NumberOfLegs("червяк");
Console.WriteLine("У червяка конечностей - " + i);
