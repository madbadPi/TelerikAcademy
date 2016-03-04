#include <iostream>
#include <string>
#include <vector>

class BigInteger
{
private:
	std::vector<int> digits;	
public:
	BigInteger();
	BigInteger(std::string num);
	//BigInteger(const BigInteger& a);
	BigInteger operator+(const BigInteger& a);

	friend std::ostream& operator<<(std::ostream& o, const BigInteger& number);
};

BigInteger::BigInteger()
{	
	digits.push_back(0);
}

BigInteger::BigInteger(std::string ininum)
{			
	int i = 0;
	int size = ininum.size();	

	for (int i = 0; ininum[i] != '\0'; i++)
	{
		int currentdigit = ininum[i] - '0';
		digits.push_back(currentdigit);
	}		
}

BigInteger BigInteger::operator+(const BigInteger& a)
{
	int carry = 0;
	int maxsize = 0;
	BigInteger first = *this;
	BigInteger second = a;
	BigInteger result;
	
	if (a.digits.size() < digits.size())
	{
		maxsize = digits.size();
		second.digits.clear();
		
		for (int i = 0; i < maxsize - a.digits.size(); i++)
		{
			second.digits.push_back(0);
		}

		for (int j = 0; j < a.digits.size(); j++)
		{
			second.digits.push_back(digits[j]);			
		}
	}
	else
	{
		maxsize = a.digits.size();
		first.digits.clear();

		for (int i = 0; i < maxsize - digits.size(); i++)
		{
			first.digits.push_back(0);
		}

		for (int j = 0; j < digits.size(); j++)
		{
			first.digits.push_back(a.digits[j]);
		}
	}
	int counter = maxsize - 1;
	result.digits.resize(counter + 1);
	while (counter >= 0)
	{
		int currentsum = first.digits[counter] + second.digits[counter] + carry;

		if (currentsum > 9)
		{
			currentsum %= 10;
			if (currentsum > 9)
			{
				currentsum %= 10;
			}
			
			carry = 1;
		}
		else
		{
			carry = 0;
		}
		result.digits[counter] = currentsum;
		counter--;
	}
	if (carry == 1)
	{
		result.digits.insert(result.digits.begin(), 1);
	}
	return result;
}

std::ostream& operator<<(std::ostream& o, const BigInteger& num)
{
	
	for (unsigned int i = 0; i < num.digits.size(); i++)
	{
		o << num.digits[i];
	}
	return o;
}

int main()
{
	BigInteger firstnum = "9999999999999999999999999";
	BigInteger secondnum = "9999999999999999999999999";	
	std::cout << firstnum + secondnum;
	std::cout << std::endl;
	return 0;
}
