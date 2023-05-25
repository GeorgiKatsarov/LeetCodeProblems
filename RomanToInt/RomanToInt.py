class Solution:
    def romanToInt(self, s: str) -> int:
        numbers = [] 
        returnint = 0
        for x in s:
            if x == "I":
                numbers.append(1)
            elif x == "V":
                numbers.append(5)
            elif x == "X":
                numbers.append(10)
            elif x == "L":
                numbers.append(50)
            elif x == "C":
                numbers.append(100)
            elif x == "D":
                numbers.append(500)  
            elif x == "M":
                numbers.append(1000)
        for i in range(len(numbers)):
            if i == len(numbers) - 1 or numbers[i] >= numbers[i+1]:
                returnint += numbers[i]
            else:
                returnint -= numbers[i]
        return returnint
