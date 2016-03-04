#include <iostream>
#include <queue>
//using namespace std;

int main()
{
	std::queue<int> q;
	std::cout << "Broi elementi:" << q.size() << std::endl;
	q.push(1);
	q.push(2);
	q.push(3);
	std::cout << "Broi elementi:" << q.size() << std::endl;
	std::cout << "Purviq element:" << q.front() << std::endl;
	std::cout << "Posledniq element:" << q.back() << std::endl;
	q.pop();
	std::cout << "Broi elementi:" << q.size() << std::endl;
	std::cout << "Purviq element:" << q.front() << std::endl;
	std::cout << "Posledniq element:" << q.back() << std::endl;
	q.pop();
	std::cout << "Broi elementi:" << q.size() << std::endl;
	std::cout << "Purviq element:" << q.front() << std::endl;
	std::cout << "Posledniq element:" << q.back() << std::endl;
	std::cout << "--------------------------" << std::endl;
	std::queue<char> a;
	a.push('a');
	a.push('b');
	a.push('c');
	a.push('d');
	a.push('e');
	a.push('f');
	a.push('g');
	std::cout << "Broi elementi:" << a.size() << std::endl;
	while (!a.empty()){
		a.pop();
		std::cout << "Broi elementi:" << a.size() << std::endl;
	}
	return 0;
}