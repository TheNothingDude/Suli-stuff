#include <algorithm>
#include <cstddef>
#include <cstdint>
#include <cstdlib>
#include <iostream>
#include <string>
#include <vector>

uint64_t sortDigits(uint64_t a) {
  std::vector<uint64_t> digits;
  std::string str;

  for (char i : std::to_string(a)) {
    digits.push_back(i - '0');
  }
  std::sort(digits.begin(), digits.end(), std::greater<uint64_t>());
  for (uint64_t i : digits) {
    str.append(std::to_string(i));
  }
  return std::stoull(str);
}

int main() { std::cout << sortDigits(41421); }
