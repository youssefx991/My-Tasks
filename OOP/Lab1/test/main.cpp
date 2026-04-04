#include <iostream>

//1. Write a program that prints your name, age, and city using std::cout.
void task1()
{
    std::cout<<"\nTask 1 ------------------------------------\n";
    std::cout<<"Name: Youssef"<<std::endl;
    std::cout<<"Age: 23"<<std::endl;
    std::cout<<"City: Cairo"<<std::endl;
}

//2. Write a program that reads two numbers and displays their sum, difference, and average
void task2()
{
    std::cout<<"\nTask 2 ------------------------------------\n";
    double n1, n2, sum, diff, avg;
    std::cout<<"Enter first number: ";
    std::cin>>n1;
    std::cout<<"Enter second number: ";
    std::cin>>n2;
    sum = n1+n2;
    diff = n1-n2;
    avg = sum / 2;
    std::cout<<"Sum: "<<sum<<std::endl;
    std::cout<<"Difference: "<<diff<<std::endl;
    std::cout<<"Average: "<<avg<<std::endl;
}

//3. Write a program that takes a decimal number and displays its hexadecimal and octal values.
void task3()
{
    std::cout<<"\nTask 3 ------------------------------------\n";
    double n;
    std::cout<<"Enter number: ";
    std::cin>>n;
    std::cout<<"Hex: "<<std::hex << n<<std::endl;
    std::cout<<"Oct: "<<std::oct << n<<std::endl;
    std::cout<<std::dec;
}

//4. Write a program that reads a character and displays its ASCII.
void task4()
{
    std::cout<<"\nTask 4 ------------------------------------\n";
    char c;
    std::cout<<"Enter character: ";
    std::cin>>c;
    std::cout<<"ASCII value: "<<(int)c<<std::endl;
}
int main()
{
//    task1();
//    task2();
    task3();
//    task4();



    return 0;
}
