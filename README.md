EN

#  ABOUT THIS PROJECT

---A very simple fund saving calculator made with C#---

A very basic calculator made for the Personal Finances subject in college. It calculates the required amount a person needs to save each month to ensure that their pension reaches the recommended amount based on their current income.

For example we have this task:
- Rasa is a 25 year old woman (40 years away from pension)
- Her wage is 800 euros/month
- Her forecasted retirement pension is 423 euros/month
- The Average yearly inflation is 4%

Additional data we know:
- Retirement age in Lithuania for men and women is 65 years old
- It is recommended that the pension would make up 70% of the monthly wage
- Average male live span is 70 years (5 years/60 months after pension), average female lifespan is 80 years (15 years/180 months after pension)

Solution to this task:

- First we find what sort of pension Rasa is expecting: <b>800 x 70% = 560 euros</b> <br>
- Rasa is expecting 560 euros for her pension, however the forecasted number is 423 euros: <b>560 - 423 = 137 euros</b>. This means Rasa will be 137 euros short each month in current monetary value. <br>
- We need to find out how much is 137 euros going to be worth in 40 years during her pension: <b> 137 x (1 + 4%/100)<sup>40</sup> = 657,74 euros </b>
- And finally, we know that in 40 years 137 euros will become 657,74 euros, that females on average live 15 years/180 months after pension, that Rasa has 40 years/480 months until pension. With this we can calculate how much Rasa has to save each month so that her pension would not be less than 70% of her current wage: <b> 657,74 x 180 / 480 = 111 393,30 / 480 = 246,65 euros/month </b>

How would this look using the calculator:

- Input the age
- Input the monthly wage
- Choose the gender
- Input the forecasted pension
- Press the button for calulations

For the results we get the total amount of money that is recommended to save up and how much money it is recommended to save up monthly. <br> <br>

<img width="682" alt="Screenshot_1" src="https://github.com/AegisSoul/TaupymoPlanas-Csharp/assets/97402640/1c468427-6dad-4fa8-8af9-4c9a639a6f17">

!!! The 4% yearly inflation is incorrect and is only applied to the task above. The inflation used in the calculator is set to 3% in the code itself due to the Lecturer's request. !!! <br>
<br>
<br>
LT

# APIE ŠĮ PROJEKTĄ

---Labai paprastas pajamų fondo taupymo skaičiuotuvas, sukurtas naudojant C#---

Tai yra labai paprastas skaičiuotuvas, sukurtas Asmeninių Finansų dalykui kolegijoje. Jis skaičiuoja reikalingą sumą, kurią žmogus turi taupyti kiekvieną mėnesį, kad užtikrintų, jog jo senatvės pensija sudarytų rekomenduojamą dydį nuo dabartinio darbo užmokesčio.




