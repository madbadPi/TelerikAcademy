#include <iostream>
#include <stack>
//using namespace std;

int main()
{
	std::stack<int> s;
	std::cout << "Broi elementi:" << s.size() << std::endl;
	s.push(1);
	s.push(2);
	s.push(3);
	std::cout << "Broi elementi:" << s.size() << std::endl;
	std::cout << "Gorniq element:" << s.top() << std::endl;
	s.pop();

	std::cout << "Broi elementi:" << s.size() << std::endl;
	std::cout << "Gorniq element:" << s.top() << std::endl;
	s.pop();
	std::cout << "Broi elementi:" << s.size() << std::endl;
	std::cout << "Gorniq element:" << s.top() << std::endl;
	std::cout << "--------------------------" << std::endl;
	std::stack<char> a;
	a.push('a');
	a.push('b');
	a.push('c');
	a.push('d');
	a.push('e');
	a.push('f');
	a.push('g');
	std::cout << "Broi elementi:" << a.size() << std::endl;
	while (!a.empty()){
		std::cout << "Gorniq element:" << a.top() << std::endl;
		a.pop();
	}
	std::cout << "Broi elementi:" << a.size() << std::endl;
	return 0;
}
