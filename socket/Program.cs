
FileInfo fileInfo = new("./receive.txt");

if (fileInfo.Exists) 
{
    Console.WriteLine(fileInfo.Extension);
} 
else {
    Console.WriteLine("nao");
}