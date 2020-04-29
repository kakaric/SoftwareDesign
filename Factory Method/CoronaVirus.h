#pragma once
#include <string>

using namespace std;

class CoronaVirus
{
private:
	string gen;
	string *hosts;


public:
	CoronaVirus();
	~CoronaVirus();


	string get_gen();
	string* get_hosts();
};