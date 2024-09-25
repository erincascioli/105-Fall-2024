using System;


// Erin Cascioli
// 9/25/24
// Demo: Compound Conditionals

namespace CompoundConditionals_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------------------------------------------------------------------------------
            // Simple Compound conditionals
            // ------------------------------------------------------------------------------------
            // These are all examples of simple compound conditionals - a single
            // if statement or if/else statement containing 2 or 3 Boolean values
            // or Boolean expressions within the condition.

            // Variables used within this block of conditionals:
            int playerGold = 246;
            bool playerInGuild = true;
            bool stealthMode = true;
            string armorType = "heavy";
            bool playerInParty = false;
            bool hasHealingPotion = true;
            const int MaxHealth = 100;
            int health = 78;
            bool hasMagicKey = false;
            bool inSafeZone = true;
            int woodSupply = 75;
            int stoneSupply = 40;
            bool inCombat = false;
            double energy = 35;
            const double MaxEnergy = 100;


            // ********************************************
            // Player is has enough gold or is part of a guild
            if ((playerGold >= 200) || playerInGuild)
            //if (playerGold >= 200 || playerInGuild)
            {
                Console.WriteLine("You purchase the rare item.");
            }
            else
            {
                Console.WriteLine("Sadly, you cannot purchase this item.");
            }


            // ********************************************
            // Stealth mode activated and wearing light armor
            if (stealthMode && (armorType == "light"))
{
                Console.WriteLine("Sneaking successful.");
            }


            // ********************************************
            // In a party and has a healing potion
            if (playerInParty && hasHealingPotion)
            {
                Console.WriteLine("You revive your fallen teammate.");
            }


            // ********************************************
            // Player has full health and holds the key
            if ((health == MaxHealth) && hasMagicKey)
            {
                Console.WriteLine("The secret door creaks open, revealing a hidden treasure.");
            }


            // ********************************************
            // In a safe zone with enough materials
            if (inSafeZone && 
                woodSupply >= 50 && 
                stoneSupply == 35)
            {
                Console.WriteLine("Sturdy shelter built!");
            }


            // ********************************************
            // Player is out of combat and has at least 50% energy
            if (inCombat &&
                (energy >= MaxEnergy * 0.5))
            {
                Console.WriteLine("Successfully fast traveled to your selected destination!");
            }
            else
            {
                Console.WriteLine("Unfortunately, your teleportation failed.");
            }



            // ------------------------------------------------------------------------------------
            // Slightly longer compound conditionals
            // ------------------------------------------------------------------------------------
            // These examples use if/elseif/else statements with compound conditionals.

            // Variables used in this block of statements:
            int playerLevel = 9;
            bool playerHasMap = false;
            int playerPerception = 20;


            // ********************************************
            // Player is high enough level and has the map OR
            // Player perception skill is very high
            if ((playerLevel >= 10 && playerHasMap) ||
                (playerPerception > 20))
            {
                Console.WriteLine("You're allowed to enter the restricted area!");
            }
            // Player's level is high enough (7 - 9) and player is perceptive enough to see the area,
            //   but cannot enter.
            else if((playerLevel >= 7 && playerLevel <= 9) &&       // Level 7, 8, 9
                    playerPerception > 18)                          // Perception 18+
            {
                Console.WriteLine(
                    "You can see the restricted area, but must gain more experience to enter!");
            }
            // Player's level is high enough (4 - 6) to sense there's something special here
            else if(playerLevel > 4)
            {
                Console.WriteLine("You sense there's something special about this area.");
            }
            else
            {
                Console.WriteLine(
                    "Your character is oblivious to the restricted area!");
            }


            // ------------------------------------------------------------------------------------
            // Compound conditionals with nested conditions
            // ------------------------------------------------------------------------------------
            // These examples use if/elseif/else statements with compound conditionals, and
            // nested conditionals further within the blocks.

            // Variables used in this block of statements:
            string equippedItem = "fishing rod";
            bool isNearWater = true;
            int fishingSkill = 5;
            string playerToken = "Merchant's Token";
            string playerAlignment = "chaotic";
            string itemAlignment = "neutral";
            bool playerInDungeon = true;
            int partyMemberCount = 4;
            string playerItem = "Wilderness Guide";
            string playerClothing = "rain cloak";
            bool isRaining = true;

            // ********************************************
            // Near the water and has fishing rod equipped
            if ((equippedItem == "fishing rod") && isNearWater)
            {
                Console.WriteLine("You cast your line into the water.");

                // Fishing skill high enough?
                if (fishingSkill >= 3)
                {
                    Console.WriteLine("The line tugs as the huge bass tries to swim away!");
                }
                else
                {
                    Console.WriteLine("Nothing bites. Better luck next time!");
                }
            }

            // ********************************************
            // Enough gold and familiar with merchant
            if ((playerGold >= 100) ||
                (playerToken == "Merchant’s Token"))
            {
                // Aligned to the item or neutral?
                if ((itemAlignment == playerAlignment) ||
                   (itemAlignment == "neutral"))
                {
                    Console.WriteLine("Successfully purchase the item!");
                }
                else
                {
                    Console.WriteLine($"Your {playerAlignment} prevents purchase!");
                }
            }

            // ********************************************
            // In dungeon with enough teammates
            if (playerInDungeon && (partyMemberCount >= 3))
            {
                Console.WriteLine("You are prepared to face the dungeon boss.");

                // Have 70% of full health or more to survive
                if (health >= MaxHealth * 0.7)
                {
                    Console.WriteLine("Healthy enough to survive the boss fight.");
                }
                else
                {
                    Console.WriteLine("Health is too low; survival unlikely.");   
                }
            }
            // Not in dungeon, or not enough teammates, or both.
            else
            {
                Console.WriteLine("Need to be in a dungeon or have at least 3 party " +
                    "members to challenge the boss.");
            }

            // ********************************************
            // High enough level with wilderness guidebook
            if ((playerLevel >= 8) || (playerItem == "Wilderness Guide"))
            {
                Console.WriteLine("You venture into the forest.");

                // Weather conditions are rainy?
                if (isRaining)
                {
                    Console.WriteLine("Rain starts to pour!");

                    // Have the proper clothing?
                    if (playerClothing == "rain cloak")
                    {
                        Console.WriteLine("Continue exploring the forest, staying dry " +
                            "under your rain cloak.");
                    }
                    else
                    {
                        Console.WriteLine("The rain is too heavy to continue without " +
                            "proper protection.");
                    }
                }
                else
                {
                    Console.WriteLine("The weather is clear, and you continue your journey " +
                        "through the forest.");
                }
            }
            // Level not high enough, or doesn’t have the guidebook, or both
            else
            {
                Console.WriteLine("You are not experienced enough or lack guidance to " +
                    "enter the forest.");
            }

        }
    }
}
