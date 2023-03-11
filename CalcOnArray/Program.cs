decimal[] Numbers = new decimal[] { 5, 8, 25, 100, 31, -54, 66, 75, 81, 55, 47 };

//Je veux plusieurs fonctions : 
//Somme du tableau
//Moyenne du tableau
//Max du tableau
//Min du tableau
//Ecart max du tableau (écart entre le min et le max)
Console.WriteLine("Somme " + getSumOfArray(Numbers));
Console.WriteLine("Moyenne " + getAverageArray(Numbers));
Console.WriteLine("Max " + getMaxOfArray(Numbers));
Console.WriteLine("Min " + getMinOfArray(Numbers));
Console.WriteLine("Ecart Max : " + getEcartMax(Numbers));

decimal getSumOfArray(decimal[] NumbersArray)
{
    decimal Sum = 0;

    //Je veux additionner à la variable Sum tous mes Numbers
    for (int i = 0; i < NumbersArray.Length; i++)
    {
        Sum += NumbersArray[i];
    }

    return Sum;
}

decimal getAverageArray(decimal[] NumbersArray)
{
    decimal Average = 0;

    //Pour calculer une moyenne, je dois Diviser la somme de tous les nombres
    //par le nombre de nombres
    decimal sum = getSumOfArray(NumbersArray);
   
    //Je veux calculer ce "count" à la main
    int count = 0;
    for(int i = 0; i < NumbersArray.Length; i++)
    {
        count++;

    }
    Average = sum / count;
    return Average;
}

decimal getMaxOfArray(decimal[] NumbersArray)
{
    decimal max = NumbersArray[0];

    foreach(var number in NumbersArray)
    {
        if(max < number)
        {
            max = number;
        }
    }
    return max;
}

decimal getMinOfArray(decimal[] NumbersArray)
{
    decimal min = NumbersArray[0];

    foreach (var number in NumbersArray)
    {
        if (min > number)
        {
            min = number;
        }
    }
    return min;
}

decimal getEcartMax(decimal[] NumbersArray)
{
    decimal ecartMax = 0;

    decimal max = getMaxOfArray(NumbersArray);
    decimal min = getMinOfArray(NumbersArray);

    ecartMax = max - min;

    return ecartMax;
}