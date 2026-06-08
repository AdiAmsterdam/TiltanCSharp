/*
set enemy health to 10
set attack damage by a random number between 3 and 6
while enemy's health is greater than zero
press enter to attack
print attack damage
enemy health will update to the health minus the attack damage
print enemy health
else
print "enemy is defeated!"
*/
int enemyHealth = 10;
int attackDamage;
do
{
    Console.WriteLine("press enter to attack");
    Console.ReadLine();
    attackDamage = new Random().Next(3, 7);
    Console.WriteLine("your attack dealt " + attackDamage + " damage.");
    enemyHealth -= attackDamage;
    Console.WriteLine("the enemy have " + enemyHealth + " hitpoints remaining");
} while (enemyHealth > 0);
Console.WriteLine("Enemy is defeated"); 


/*
set enemy health to 10
set number of attacks to 4
set attack damage by a random number between 1 and 4
for from 1 to number of attacks, increase by 1 each loop
print attack damage
set enemy health to enemy health minus attack damage
print enemy health
if enemy health is less or equals to 0
print "enemy is defeated"
break the loop
else
print "enemy won!"
print enemy health
*/

int enemyHealth2 = 10;
Console.WriteLine("Enter number of attacks");
int numberOfAttacks = int.Parse(Console.ReadLine());
int attackDamage2;
for (int i = 1; i <= numberOfAttacks; i++)
{
    attackDamage2 = new Random().Next(1, 5);
    Console.WriteLine("your attack did " + attackDamage2 + " damage");
    enemyHealth2 -= attackDamage2;
    Console.WriteLine("the enemy have " + enemyHealth2 + " hitpoints remaining");
    if (enemyHealth2 <= 0)
    {
        Console.WriteLine("enemy is defeated");
        break;
    }
    if (i == numberOfAttacks)
    {
        Console.WriteLine("enemy’s health: " + enemyHealth2);
        Console.WriteLine("Enemy won!");
        break;
    }
}