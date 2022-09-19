Console.Clear();

string[] array = new string[4];

void PrintArray(string[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] FillArray(string[] array){
    for(int i = 0; i<array.Length; i++){
        Console.WriteLine("Enter array member string: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

FillArray(array);
PrintArray(array);

int CountNewArraySize(string[] array){
    int count = 0;
    for(int i = 0; i<array.Length; i++){
        if(array[i].Length<=3){
            count++;
        }
    }
    return count;
}
int newArraySize = CountNewArraySize(array);
string[] newArray = new string[newArraySize];

string[] CreateNewArray(string[] array, string[] newArray){
    int j=0;
    for(int i = 0; i<array.Length; i++){
        if(array[i].Length<=3){
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

CreateNewArray(array, newArray);
PrintArray(newArray);