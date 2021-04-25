using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextAsset table;
    public string[] rolls;

    string[] stages;
    string[] grassyEvents;
    string[] sandyEvents;
    string[] townEvents;
    string[] beachEvents;
    string[] volcanoEvents;
    string[] spaceWhaleEvents;
    string[] caveEvents;
    string[] icebergEvents;
    string[] oceanEvents;
    string[] atlantisEvents;
    string[] krakenEvents;
    string[] enchantedForestEvents;
    string[] jungleEvents;
    string[] hellEvents;

    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        rolls = new string[10001];
        StringBuilder singleLine = new StringBuilder();

        foreach (char c in table.text)
        {
            if ((c != '\n'))
            {
                singleLine.Append(c);
            }
            else
            {
                rolls[counter] = singleLine.ToString();
                singleLine.Clear();
                counter++;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void setStagesEvents()
    {
        stages = new string[] { "Grassy Plains", "Sandy Desert", "Town Square", "Beach Day", "Enchanted Forest", "Jungle", "Volcano", "Space Whale", "Cave", "Iceberg", "Ocean", "Atlantis", "Kraken" };
        grassyEvents = new string[] {"Herd of wildebeest, everyone takes damage equal to 15 minus their height!",
            "The wind blows.",
            "Earthquake, players 5 feet or taller drop to their knees, if you drop with more than 2 beans in your hands you drop one!",
            "Tectonic movement: a subterranian volcano emerges from underneath your feet, you are now in the volcano stage!",
            "The grass grows.",
            "Horse armory event! A horse with a bunch of knives sticking out of its flesh runs past, a player can grab one on their turn! If you grab one roll the d4, on a 4 the dagger is actually made of diamond and is worth 10 gold!",
            "A caravan of elephants rolls by and takes everyone to the town square!",
            "A mentally challenged mage appears screaming and teleports the party to a random stage!"};
        sandyEvents = new string[] {"Sand Storm! Targets are chosen at random for a round.",
            "Tumbleweeds tumble on by.",
            "Large tumbleweeds roll by and snatch up players 1 foot tall! They miss a turn before returning on their next turn.",
            "Heat wave! If you don't have any water you take 4 dehydration damage.",
            "Quick sand! Everyone sinks and falls into the cave stage.",
            "Sand surfer chads come and sand surf you over to the beach stage!",
            "Swarm of giant ants! Players are forced to flee to the nearest random land stage."};
        townEvents = new string[] {"A racist farmer cusses out everyone of a different race than his for 3 psychic damage.",
            "A blubbering fool rolls past and fires a gun at Tom's character's kneecap for his negativity, he drops his beans!",
            "Shopping spree! A travelling merchant offers you these options for 10 gold: 10hp potion, basic weapon, bean holder, floaters, water flask",
            "A dapper gentleman passes by and drops a sack of gold in the middle of the battle, the fastest willing player can snatch it up.",
            "Beach day! Swarms of towns folk run to the beach taking you all with them!",
            "A band of handsome adventurers carry you to the jungle.",
            "A Satyr Beckons you into a dark alley where he bursts through a door and brings everyone to the enchanted forest!"};
        beachEvents = new string[] {"The sea level rises by 1 foot! If the sea levels gets to your height you must use your turn to stay afloat, you can only carry one bean.",
            "A king crab shows up and attacks a random player for 5 damage! It stays and keeps attacking until it is killed, and its claw can be used as a weapon!",
            "You discover a sand castle with 2 plastic shovels! The players can pick them up immediately, the fastest players get dibs!",
            "A tidal wave washes the shorter wizards out to sea for a turn! If your height is equal to the sea level plus 2 or less then you are affected.",
            "A large tidal wave washes all the players out into the oceans!",
            "Winter is coming, nordic winds push you on to an iceberg, you are now in the iceberg stage!",
            "Some air bending surfer chads offer you a ride to a random normal stage."};
        volcanoEvents = new string[] {"Eruption, if the volcano is active it's instant death unless immune to fire (if volcano is dormant it now becomes active)(if the players are on the obsidian slab they get yeeted into a space stage) ",
            "SO2, wizards above 4 feet tall suffocate for 12 damage before realising they must duck (you gain sulfur immunity, its magical.) ",
            "Volcano becomes dormant. ",
            "RockSlide, if your speed is 5 or below you get hit by rocks for 8dmg (if everyone is hit you all tumble down the volcano for twice the damage and land in a land stage). ",
            "Obsidian slab event, water drops from the sky creating and obsidian slab in the middle of the volcano where the players proceed to fight. ",
            "Old man passes by in a lava river upon a obsidian raft, the players hop on and are brought to the ocean where they are kicked off( the players have a round on the boat while this happens, players that drop unconscious or asleep fall off into the lava) "};
        spaceWhaleEvents = new string[] {"Asteroid field, if your speed is under 8 you get hit for 20dmg",
            "Water spouts out of the blowhole ejecting the players back down to a random normal stage.",
            "The stars align, if you roll 10000 you win ",
            "The stars misalign: if you roll a 1 you lose and your ethereal bean explode like fireworks as the stars align once again"};
        caveEvents = new string[] {"Carbon dioxide leak, wizards above 4ft suffocate for 6 damage before realising they must duck.",
            "Stalactites fall on 1d4 players dealing 15dmg.",
            "Stalagmites, there are stalagmites.",
            "Vein of gold, if you are a dwarf you are able to extract it from the wall (10gp). ",
            "Dwarves in minecarts: they minecart you out of the cave into one of the land stages. ",
            "Giant Moles dig you a way out of the cave, everyone exits to the grassy plains!",
            "Sea level rises, washes you out to the ocean through a series of underwater caves, players take 5 suffocation damage."};
        icebergEvents = new string[] {"A Large spectral moth, douses the players in its snowy wing powder as they realise they are now in the enchanted forest.",
            "Ice skitters declare the iceberg their territory and attack the player for 1 damage per turn","It starts to snow (if it's already snowing its a blizzard) target’s are chosen at random for a turn.",
            "Christmas miracle! Everyone receives 10gold and it starts to snow (if it's already snowing it becomes a blizzard and targets are chosen at random for a turn.",
            "Christmas event: if your character hasn’t killed anyone you get a free item from the shop(candy cane weapon, 10hp potion, a bean holder(holds a bean), blank, floaters)",
            "Global warming, the iceberg melts, hold onto your beans the iceberg melts throughout the turn, at the end of the turn you are now in ocean stage."};
        oceanEvents = new string[] {"Shark attack, the juiciest(tallest) player gets attacked by sharks dealing 10dmg.",
            "Man o’ war Jellyfish entangles and kills the slowest player.",
            "The water seems wet. ",
            "Pirates navigate by the players, the ship and the crew can be targeted for a turn. Any player who manages to hit a pirate with something receives a gold doubloon from him worth 10 gold!",
            "Whirlpool, the players are swept into Atlantis. ","Kraken emergence, tentacles appear around the players next emergence: players are now on a kraken",
            "Tsunami washes the players onto any land stage NEXT TURN, if more than one bean is held they are lost",
            "Global cooling, an iceberg emerges underneath the players sending them to the iceberg stage."};
        atlantisEvents = new string[] {"A giant portal room is found in the middle of the city, players go to a random stage",
            "Traveling gipsy merfolk open up shop for a turn, all items cost 10 gold: Trident (8dmg), Floaters, Bean Holder)"};
        krakenEvents = new string[] {"Kraken tentacles grab the slowest player and does so again every turn, once all players are grabbed they are flung to a land stage.",
            "Kraken tentacles grab the slowest player and does so again every turn, once all players are grabbed they are flung to a land stage.",
            "Kraken tentacles grab the slowest player and does so again every turn, once all players are grabbed they are flung to a land stage.",
            "Feeding time, one of the grappled players gets eaten"};
        enchantedForestEvents = new string[] {"Roll your beans twice this turn.",
            "Cupids fawn, a spectral fawn selects two people to become allies, they become souls mates and share an ethereal bean storage. They must win together by gathering collectively double the number of beans.",
            "No beans, beans become ordinary glass beans for a round (no magic).",
            "Halfling’s luck, halflings this turn can only be targeted by positive effects and they can use their action to find 10 gold in the mystical wilds.",
            "Sleep pixies: the players fall asleep and wake up in a different random land stage."};
        jungleEvents = new string[] {"Tarzan snatches up the smallest player making him drop all but one bean, tarzan returns next turn until no ones left leading them all to a new land stage.",
            "Poisonous snakes come and bite your genitals for 7 poison damage.",
            "A gold statue worth 10 gold falls from the sky! The next person in the turn order can take 10 damage and catch it . If he chooses not to, that same option presents itself to the next person in the turn order.",
            "Low hanging fruit, elves and goliaths can reach these fruits, a free hand can be used to pluck and eat a fruit restoring 5hp."};
        hellEvents = new string[] {"Limbo: roll for faith, if you are faithless take 6 psychic damage.",
            "Lust: Harsh winds blow every player 3 ft and below in to jagged rocks taking 6damage.",
            "Gluttony: bucket of fried chicken appears with herbs and spices(there is enough for everyone), if a player eats the chicken cerberus throws a snowball at you for 6dmg. ",
            "Greed Forced to drag boulders strapped to your chest the one that falls behind gets squished by his boulder(pushing effectiveness is calculated by multiplying speed an height) ",
            "Anger: Atop a barge on river styx players do triple damage for a turn (an old man in a gondola passes by)","Heresy: your faith is tested once again roll! If you fail a second time take 12dmg if you passed the first time but failed this time take 6dmg ",
            "Violence: take 6*number of players killed damage from the boiling blood at your feet for being a murderer, if you’ve committed suicide(through drowning) in a past life take 6dmg as scorching sand burns your feet. ",
            "Fraud, roll 1d9: \n1.Whipped by demons 6dmg. \n2.Steeped in excrement 6dmg. \n3.Placed in holes head first with their legs exposed and burned 6dmg. \n4.Contorted until their heads are half backward, death. \n5.Soul burns wrapped in columns of flame 7dmg. \n6.Suffer from fever and headache 2dmg. \n7.Disfigured by dropsy and exhausted by thirst 6dmg. \n8.Relaxed compelled to scratch their itching skin, you just itchy. \n9.Forced to wear cloaks of lead(speed 0, all you can do is roll bean).\n10.Split from chin to groin by sword death ",
            "Treachery frozen waste land last one standing gets 2 extra beans in their ethereal storage, the party then respawns in a random land stage."};
    }
}
