using System.Reflection.Metadata;
using ConsoleApp1;
using System.IO;
using System.Runtime.CompilerServices;
using System.ComponentModel;



int nuvarande_rum = 0;   // wile loppar 
int handling = 0;    // beslut
int hooded_win = 0;   // dum variabel
bool Bribe = false;    // saker
bool Coins = false;
bool Poision = false;
bool Dead = false;


/*
static void texter()
{
  Console.WriteLine("Hej!");
}
texter();
*/

/*
texter_rum f1 = new texter_rum();

string n = f1.GetName();
Console.WriteLine(n);

*/



Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();
Console.WriteLine("Not my cup of tea. I think i need som coffe after this..");

String filepath = @"C:\Users\david.eriksson5\Programering VS\Ny mapp\ConsoleApp1\ASCII.txt";
string info = File.ReadAllText(filepath);
Console.WriteLine(info);
Console.ReadLine();


//ClassRum Tavern = new ClassRum();
//Tavern.printonscrean();





Console.Clear();
Console.WriteLine(@"Ah, welcome, weary traveler, to the humble abode of ale and tales. Sit yourself down, rest those tired bones, and let the warmth of the hearth seep into your spirit. You see, this isn’t just any old night, and you’re not just any old patron in my tavern. No, fate has woven a far grander design for you, my friend.

I’ve seen many a soul pass through these doors, each with their own story etched upon their face. But you, you’ve got that spark in your eye, that unspoken yearn for adventure that cannot be quenched by mere drink or jest. It’s as if the stars themselves have etched their light upon your destiny.

Now, lean in close, for what I’m about to impart isn’t for the idle ears of the common folk. There’s a tale, old as the mountains and as true as the north star, of a quest so grand it could forge a legend or doom a soul to eternal whispers. And you, brave adventurer, have been chosen by the unseen forces that guide our fates.

Beyond the misty peaks of the Eldritch Mountains lies a treasure so vast and ancient it’s said to hold the power of the gods themselves. Many have sought it; none have returned. It’s not just beasts and brambles that guard this prize but something older, something wiser and far more cunning.

But why you? Why now? I cannot say. Perhaps it’s your courage that calls forth this destiny or maybe just blind chance. But one thing is certain: this quest is yours to undertake. Will you rise to meet it? Will your name be sung by bards in ages to come?

So take this map, etched by hands unknown, and gather your wits and weapons. For when dawn breaks, your journey begins—not just across lands unknown but into the very annals of history itself.

Remember this night, adventurer, for it is the prologue to your legend. Now go forth and let your story unfold!");
Console.ReadLine();
Console.Clear();
Console.WriteLine(@"The taverkepp turns hastly around starting to service a roudy group of haflings. Leving you trobuled, pondering the hevy burden that has been placed upon you. The dimly lit tavern buzzes with the chatter of travelers and locals alike. 

The wooden beams overhead creak occasionally, and the air is thick with the scent of ale and roasting meat. A large stone fireplace crackles warmly in the corner, casting flickering shadows across the room. Rough-hewn tables are scattered about, some occupied by patrons engrossed in conversation or games of dice. 

Behind the bar, a grizzled barkeep polishes a mug, keeping a watchful eye on the room. Shelves lined with various bottles and curios adorn the walls, and a set of stairs leads up to a balcony overlooking the common area, where a few private booths offer more secluded seating. ");
Console.ReadLine();
Console.Clear();


// ## död = död?
while (Dead == false) {
// ##


while (nuvarande_rum == 0) // WHILE Tavern, scen 1. #Poision#, tre händelser, lämna  
{
    
Console.Clear();

Console.WriteLine(@"Choice 1. Inspect the fireplace: Approach the large stone hearth and examine the intricate carvings on the mantel, or perhaps see if there's anything hidden behind the firewood stacked nearby.

 Choice 2. Investigate the bar: Head over to the bar and engage the barkeep in conversation. You might spot something interesting behind the counter or catch sight of a strange bottle on the shelves.

 Choice 3. Explore the upstairs balcony: Ascend the creaky wooden stairs and inspect the private booths. There could be something unusual left behind by a previous patron, or a conversation to overhear.
 
 Choice 4: Leave the Tavern: Head toward the door and step out into the night, leaving the warmth of the tavern behind as you embark on your journey into the unknown.
 -----------------------------------------------------------------------------------------------------------------------
 ");


Console.WriteLine(@"What do you want to interackt whit? 1,2,3 or 4
");
string handlingg = Console.ReadLine();
Console.Clear();

switch ((string)handlingg) { // beslut vart 
case (string)"1":
handling = 1; // Eld
break;
case (string)"2":
handling = 2; // Bar
break;
case (string)"3":
handling = 3; //balcong
break;
case (string)"4":
nuvarande_rum =+ 1; //Lämna
handling = 0;
break;
} // Switch


switch ((int)(handling)) { //responce vart
case (int)1:
Console.WriteLine(@"As you approach the large stone fireplace, the warmth from the crackling flames washes over you, a welcome contrast to the chill outside. The firelight dances across the room, casting long shadows on the worn wooden floor. You notice that the hearth is made of heavy, dark stones, worn smooth by years of use. The mantel above is simple but sturdy, adorned with a few dusty trinkets—perhaps old trophies or tokens left by past patrons.

Leaning in closer, you can feel the heat radiating from the logs, the wood popping and crackling as it burns. The smell of burning oak fills the air, mingling with the scent of roasting meat. You run your hand along the edge of the mantel, feeling the rough texture of the wood beneath your fingertips. 

You take a moment to examine the intricate carvings etched into the stone—a pattern of twisting vines and leaves, faded with time but still visible. There’s nothing out of the ordinary here, just the comforting warmth of the fire and the quiet hum of the tavern around you.

Satisfied that the fireplace holds no secrets, you step back, the glow of the flames still flickering in the corner of your eye as you turn your attention elsewhere.");
Console.ReadLine();
break;
case (int)2:
Console.WriteLine(@"As you approach the bar, the smell of ale and old wood grows stronger. The grizzled barkeep gives you a nod, but he's too busy polishing a mug to strike up a conversation. Your eyes wander to the shelves behind him, lined with bottles of various shapes and sizes. Most are filled with the usual brews, but one bottle catches your eye—a small, dusty flask with a strange, shimmering liquid inside.

Curiosity gets the better of you. While the barkeep is distracted, you subtly reach for the bottle. The liquid inside swirls with an unnatural iridescence, almost glowing in the dim light. You quickly slip the flask into your pouch, feeling its cool glass press against your side.

Without drawing attention, you step away from the bar, your fingers still tingling from the mysterious find.");
Console.ReadLine();
break;
case (int)3:
Console.WriteLine(@"You climb the creaky stairs to the upstairs balcony. The wooden floorboards groan under your weight as you glance around. The private booths are empty, their seats worn from years of use. The air is still, and faint murmurs from below drift up to you. 

Aside from the quiet and a slightly better view of the tavern, nothing catches your eye. After a brief look, you head back down, finding nothing of interest.");
Poision = true;
Console.ReadLine();
break;
 } // Switch text

} // WHILE, rum 0  #Tavern#

while (nuvarande_rum == 1) { // WHILE rum 1 & 0 beslut lämna? 
Console.WriteLine(@"As you stand near the tavern’s entrance, the chill from outside seeps in with each swing of the door. The sounds of the lively crowd fade behind you. You can choose to step out into the night, leaving the warmth and bustle behind, or linger a moment longer, savoring the last traces of the tavern's comforting atmosphere before heading out on your journey.
Are you sure you want to leave the tavern?
------------------------------------------------------------------------------------------------------------------------

Choice 1. I want to start my adventure!

Choice 2. I've changed my mind
");

string handlingg = Console.ReadLine();
Console.Clear();

switch ((string)handlingg) { //Lämna ja & Nej
case (string)"1":
nuvarande_rum = 2;
break;
case (string)"2":
nuvarande_rum = 0;
break;
} //switch

} // WHILE rum 1 & 0 beslut lämna? 



Console.WriteLine(@"You push open the heavy wooden door and step out of the tavern. The brisk night air hits you immediately, a sharp contrast to the warmth inside. The narrow cobblestone street stretches out before you, dimly lit by flickering lanterns hanging from iron posts. The buildings around you are a patchwork of stone and timber, their windows darkened as the town settles into the quiet of the night.

Above, the sky is a deep, endless black, dotted with faint stars. The moon casts a pale glow, illuminating the mist that clings to the ground. In the distance, you hear the faint rustle of leaves and the occasional bark of a distant dog. The streets are mostly deserted, save for a stray cat darting between shadows.

You tighten your cloak against the cold, your breath visible in the chill air. The path ahead is yours, leading you away from the safety of the tavern and into the unknown night.");
Console.ReadLine();
Console.Clear();
Console.Write(@"Leaving the cobblestone streets behind, you follow a narrow dirt path that leads toward the looming forest at the edge of town. The trees rise like dark sentinels against the night sky, their branches intertwining to form a thick canopy overhead. As you step into the forest, the sounds of the town fade away, replaced by the quiet rustling of leaves and the occasional hoot of an owl.

The air here is damp and cool, carrying the earthy scent of moss and decaying wood. Your footsteps crunch softly on the forest floor, covered in a blanket of fallen leaves. The path twists and turns, sometimes disappearing entirely beneath the undergrowth, but you press on, navigating by the faint moonlight that filters through the trees.

Hours pass as you travel deeper into the wilderness. The forest thickens around you, the trees growing taller and more ancient. Occasionally, you spot the distant glow of a firefly or the skittering of small creatures in the underbrush, but otherwise, the woods are silent. You cross shallow streams, their waters icy as they slip over smooth stones, and climb gentle slopes that rise like waves in the landscape.

As the night wears on, the terrain shifts from dense forest to rolling hills and back again. Your legs grow weary, but you push forward, determined to cover as much distance as possible before dawn. The forest seems endless, a vast sea of trees that stretches in every direction, but you keep moving, the steady rhythm of your footsteps the only constant in this vast, quiet world.");
Console.ReadLine();
Console.Clear();
Console.Write(@"As you journey deeper into the forest, the trees begin to blur together, their twisted branches and shadowed trunks becoming an endless maze. You pause occasionally, trying to get your bearings, but the forest offers no clear direction. Doubt creeps in. Have you strayed too far from the path? Are you heading the right way, or have you been wandering in circles?

The silence of the woods feels oppressive now, every step weighed down by uncertainty. You glance back, but the way you came is swallowed by the darkness of the forest. There's no turning back now. With a deep breath, you push forward, trusting your instincts, though each decision feels more uncertain than the last.

Hours pass in this uneasy state until, finally, the trees begin to thin. The dense foliage gives way to patches of open ground, and the sound of the forest fades. You emerge from the woods and find yourself standing on the edge of a vast, open field. The grass sways gently in the night breeze, stretching out before you like a rolling sea of silver in the moonlight.

For the first time in hours, you can see the sky fully, the stars clear and bright above you. The openness of the field feels both freeing and disorienting after the confines of the forest. You pause, unsure of your next move, but at least here, under the vast expanse of the night, the world seems a little clearer.");
Console.ReadLine();
Console.Clear();

while (nuvarande_rum == 2) { // WHILE, fältet, Rebel, 3 beslut. rum 2
Console.Clear();

Console.Write(@"As you stand in the open field, the silence is suddenly broken by the soft crunch of footsteps behind you. Before you can react, a hooded figure steps out of the shadows, appearing as if from nowhere. Their face is obscured, but their voice is low and sharp.

I've been watching you, they whisper, barely more than a shadow against the night. I have a proposition. The king of the nearby kingdom—a man unworthy of his throne—needs to be removed. Do this for me, and you'll be richly rewarded.

The air around you feels colder as the offer hangs in the stillness, and you realize this encounter was no accident.
------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine(); 
Console.Write(@"
Choice 1: Accept the Offer

Choice 2: Decline the Offer

Choice 3: Punch the Hooded Figure

");

string handlingg = Console.ReadLine();
switch ((string)handlingg) { // beslut rebellen
case (string)"1":
handling = 1;
break;
case (string)"2":
handling = 2;
break;
case (string)"3":
handling = 3;
break;
} // switch

switch ((int)(handling)) { // recponce rebellen
case (int)1:
Console.Clear();
Console.WriteLine(@"You glance at the parchment, weighing the hooded figure's words. After a moment of silence, you nod. The figure's hand shifts slightly, and before you realize it, a small, cold object is pressed into your palm—a silver coin. Good choice, they murmur. Instructions will follow. Without another word, the figure melts into the shadows, vanishing into the night as if they were never there. The coin glints in the moonlight, a silent promise of the dark task ahead.");
nuvarande_rum = 4;
Console.ReadLine();
break;
case (int)2:
Console.Clear();
Console.WriteLine(@"You shake your head, stepping back from the hooded figure. I’m not interested, you say firmly. The figure stiffens, and before you can react, they draw a slender dagger from their cloak, eyes glinting with murderous intent. Pity, they hiss. The cold steel flashes in the moonlight as they lunge at you, intent on silencing you forever.");
nuvarande_rum = 3;
Console.ReadLine();
break;
case (int)3:
Console.Clear();
Console.WriteLine(@"The hooded figure's offer doesn’t sit right with you. Without warning, you clench your fist and throw a punch, connecting squarely with their jaw. The figure stumbles back, surprise flashing across their hidden features. Recovering quickly, they draw a blade, their stance shifting into a defensive posture. The fight is on, both of you now locked in a deadly dance under the open sky.");
nuvarande_rum = 3;
hooded_win = 1;
Console.ReadLine();
break;
 } handling = 0;    // switch

} // WHILE, fältet, Rebel, 3 beslut. rum 2



while (nuvarande_rum == 3) { // WHILE, fysisk handling #Död# #Coins#  rum 3
if (hooded_win == 1) { // slag rebellen, #Coins#
Console.WriteLine(@"Your punch catches the hooded figure off guard, but they recover quickly, drawing a blade and lunging at you with swift, precise strikes. You narrowly dodge the first few attacks, feeling the cold wind of the blade just inches from your skin. Adrenaline surges through you as you counter with a well-placed kick, sending the figure stumbling backward.

They regroup, trying to slash at you again, but this time, you're ready. You sidestep their attack and, with a powerful swing, knock the blade from their hand. The weapon clatters to the ground, and you follow up with a hard strike to their gut. The figure doubles over, gasping for breath. With one final blow, you send them crashing to the ground, unconscious.

Panting, you stand over the defeated figure, the night air cold against your sweat-drenched skin. You quickly search them, finding nothing of value except a small pouch of coins which you quickly secure to your belt. Satisfied, you leave them lying in the dirt, disappearing into the night with victory at your back.");
nuvarande_rum = 4;
Coins = true;
} else { // choice 2, #Död#

Console.WriteLine(@"They draw their blade with deadly precision, and before you can react, they strike. You dodge the first few slashes, but the figure is relentless, their movements sharp and calculated.

A sudden pain flares in your side as the dagger finds its mark. You stagger back, clutching the wound, but the figure doesn’t give you time to recover. They press the attack, landing another blow that sends you to your knees.

The cold ground presses against you as the hooded figure stands over you, their blade dripping with your blood. You should have chosen more wisely, they whisper. As darkness begins to close in around you, the last thing you see is the figure disappearing into the night, leaving you behind to face your fate.");
nuvarande_rum = -1;
Dead = true;
} // choice 2, #Död#

} // WHILE, fysisk handling #Död# #Coins# rum 3

Console.Clear();
Console.WriteLine(@"The night stretches on as you travel, your footsteps steady and determined. The sky above gradually shifts from inky black to the deep blue of early dawn, the stars fading one by one. The chill of the night air lingers, but a faint warmth begins to creep in as the first light of day brushes the horizon.

Hours pass, the world around you slowly brightening. The forest has long since faded behind you, replaced by rolling hills and open plains. The journey has been long, but as the sky finally breaks into the soft hues of morning, your persistence is rewarded.

Far in the distance, bathed in the golden light of the rising sun, you see it—a kingdom. The distant spires of the castle reach toward the sky, surrounded by the faint outlines of walls and rooftops. It’s a sight that fills you with a mix of anticipation and uncertainty, the sprawling city both a destination and a mystery.

With renewed energy, you press on, the kingdom growing ever closer with each step.");
Console.ReadLine();
Console.Clear();
Console.WriteLine(@"As you draw closer to the kingdom, its immense size becomes undeniable. The towering stone walls stretch high into the sky, their weathered surfaces marked by the passage of time and countless battles. The sheer scale of the fortress leaves you momentarily breathless, each step bringing you closer to the heart of this sprawling domain.

The gates loom ahead, a massive structure of iron and oak reinforced with thick steel bands. They stand at least three times your height, their heavy doors adorned with intricate carvings of ancient symbols and battles long forgotten. Flanking the gate are two colossal statues, stone sentinels that guard the entrance with silent vigilance, their stern faces etched with deep lines of age and wisdom.

As you approach, you can see the faint shimmer of the kingdom’s banner fluttering high above the walls, a reminder of the power and authority that lies within. The air is filled with the distant hum of activity from beyond the gate—merchants, guards, and the everyday bustle of a thriving city.

The path beneath your feet transitions from dirt to smooth, well-worn stone as you near the gates. You stand before them now, dwarfed by their size, the kingdom’s enormity stretching out before you like a vast and uncharted world, waiting to be explored.");
Console.ReadLine();


while (nuvarande_rum == 4) { // WHILE Riket, interigation, bra/dålig  rum 4
Console.Clear();

Console.WriteLine(@"As you approach the towering gates, a pair of armored guards step forward, their eyes sharp beneath the visors of their helmets. One of them raises a hand, signaling you to stop. His voice echoes with authority as he speaks, his tone firm yet measured.

Halt! State your business, traveler. What is your purpose for entering our kingdom? His gaze lingers on you, scrutinizing every detail of your appearance. 

He steps closer, his hand resting casually on the hilt of his sword. And tell me—where do you come from? We've had our share of trouble lately, so you'll need to be clear about your intentions. 

The other guard stands watchful, waiting for your response, the weight of the kingdom's towering presence pressing down as you prepare to answer.
------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();


Console.WriteLine(@"Choice 1: Be Honest and Direct  
Answer the guards truthfully, stating your purpose for visiting the kingdom and where you’ve traveled from. Show them you mean no harm and hope to pass through without issue.

Choice 2: Be Vague and Mysterious  
Offer the guards only the bare minimum of information, keeping your answers vague. Mention you're a traveler with personal business and leave out specific details, hoping they won’t press further.
");


string handlingg = Console.ReadLine();
switch ((string)handlingg) { // beslut port vakter
case (string)"1":
handling = 1;
break;
case (string)"2":
handling = 2;
break;
} // switch

switch ((int)(handling)) { // responce port vakter
case (int)1:
Console.Clear();
Console.WriteLine(@"The guards exchange a brief glance, their expressions hardening. The one who spoke first tightens his grip on his sword, his eyes narrowing. You'll need to come with us.

Before you can respond, the guards move to flank you, their posture leaving no room for negotiation. They lead you through the gates and into the heart of the kingdom, the bustling streets giving way to the cold, stone walls of a guardhouse.

Inside, you are escorted to a small, dimly lit room. The door creaks as it closes behind you, leaving you alone with only a wooden table and two chairs. The walls are bare, save for a single, narrow window high above, casting thin slivers of light across the room.");
nuvarande_rum = 5;
Console.ReadLine();
break;
case (int)2:
Console.Clear();
Console.WriteLine(@"The guards exchange a brief glance, their expressions hardening. The one who spoke first tightens his grip on his sword, his eyes narrowing. Your answers raise more questions than they settle, he says firmly. We can't let you pass without further inquiry. You'll need to come with us.

Before you can respond, the guards move to flank you, their posture leaving no room for negotiation. They lead you through the gates and into the heart of the kingdom, the bustling streets giving way to the cold, stone walls of a guardhouse.

Inside, you are escorted to a small, dimly lit room. The door creaks as it closes behind you, leaving you alone with only a wooden table and two chairs. The walls are bare, save for a single, narrow window high above, casting thin slivers of light across the room. The air is thick with the weight of anxiety as you await in silence");
nuvarande_rum = 5;
Console.ReadLine();
break;

 } //switch
} // WHILE Riket, interigation , bra/dålig  rum 4




Console.Clear();
while (nuvarande_rum == 5) { // interigation, fri, fång, rum 5


if (handling == 2) { // dålig interigation
                                    
while (handling == 2) { // dålig interigation, muta (fri given), tyst (Cell)
// Hostile
Console.WriteLine(@"The door to the room swings open with a harsh creak, and two guards enter, their expressions stern. One of them, a tall man with a scar across his cheek, slams a thick file onto the table, his eyes boring into you with suspicion.

Sit, he commands, his tone cold and authoritative. You comply, the tension in the room palpable. He paces slowly around the room, his boots echoing against the stone floor. You’ve been vague about your reasons for entering the kingdom. We don’t take kindly to strangers who can’t explain themselves.

The other guard leans against the wall, arms crossed, his gaze never leaving you. The tall guard continues, his voice growing sharper. Who are you really? What business do you have here? If you think you can lie your way out of this, you’ll find our patience is very thin.

He leans forward, hands pressing hard on the table, inches from your face. Start talking. Or things will get much worse for you.
------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();

Console.WriteLine(@"1: Be Quiet
");

if (Coins == true) { // möjligheten att muta anars inte synas
Console.WriteLine(@"Coins 2: Bribe the guard
");
}

string handlingg = Console.ReadLine();
Console.Clear();

switch ((string)(handlingg)) {
case (string)"1":
break;

case (string)"2":
Bribe = true;
handling = 0;
Coins = false;
nuvarande_rum = 7;
break;
} // switch

}// dålig interigation

if (Bribe == true) // muta (fri given)
{
Console.WriteLine(@"As the guard drags you toward the door, panic surges through you. Desperate, you reach into your pouch and pull out the small bag of coins you took from the hooded figure earlier. Wait, you say urgently, your voice low. Maybe we can work something out.

The guard pauses, glancing at the pouch in your hand. His grip on your arm loosens slightly, and he eyes the bag with a calculating look. You can see the wheels turning in his mind as he weighs his options.

How much? he asks, his voice still hard, but now tinged with interest.

You open the pouch just enough for him to see the glint of silver coins inside. Enough to forget what I just said. I have no interest in rebels, and no one else needs to know about our conversation.

He stares at you for a long moment, then snatches the pouch from your hand. He counts the coins quickly, his expression softening as he pockets them. Finally, he releases your arm entirely and steps back, his anger fading.

Fine, he mutters, his tone more resigned than hostile. I didn’t hear a thing. But you’d better get out of here before someone less reasonable asks questions.

Without another word, he opens the door and gestures for you to leave, his eyes already shifting away as if trying to erase the memory of your interaction. Relieved, you step out of the room and into the corridor, knowing you’ve narrowly escaped a far worse fate.");
Console.ReadLine();

} else { // cell
Console.WriteLine(@"The tall guard's eyes narrow as the silence stretches on, your refusal to speak clearly testing his patience. He straightens up, his expression darkening. So, that’s how it’s going to be, he mutters, his voice cold with irritation.

He nods to the other guard, who steps forward with a harsh, deliberate movement. If you won’t talk, we have other ways of dealing with uncooperative visitors, the tall guard says, his tone final. You’ll be spending some time in a cell until you decide to change your mind.

Before you can react, the second guard roughly grabs your arm, hauling you to your feet. They lead you out of the interrogation room and down a narrow, dim corridor, their grip unyielding. The sound of metal scraping against stone echoes as a heavy door swings open, revealing a small, dark cell.

Without ceremony, they shove you inside. The door slams shut behind you, the iron bars rattling as the lock clicks into place. The cold, damp air of the cell wraps around you as you’re left alone in the dim light, the echo of their footsteps fading as they walk away.");
Console.ReadLine();
nuvarande_rum = 6;
Console.Clear();
} // cell 


} else { //                        ↓
while (handling == 1) { // lugn interigation 

//Calm
Console.WriteLine(@"The door opens, and a single guard steps in, his demeanor calm and unthreatening. He takes a seat across from you, placing a small notepad on the table with a soft thud. Thanks for waiting, he says with a nod, his voice steady and neutral. We just need to clear up a few things before we let you go. No need to worry.

He leans back in his chair, glancing at his notes. So, let’s start with the basics. Why are you here, and where have you come from? We’ve had some security issues lately, so we’re just being thorough.

His eyes meet yours, friendly but still watchful. You don’t seem like trouble, but we have to follow protocol. Just give me some straight answers, and we’ll get you on your way as quickly as possible. He folds his hands on the table, waiting patiently for your response, the atmosphere far more relaxed but still with an air of formality.
------------------------------------------------------------------------------------------------------------------------");
Console.ReadLine();

Console.WriteLine(@"
Choice 1: Tell him some of it (Leving out the houded figure).

Choice 2: Tell him every thing.
");
string handlingg = Console.ReadLine();
Console.Clear();


switch ((string)(handlingg)) { // 1 berättar inte allt(fri)  2 berätar allt (cell)
case (string)"1": 
Console.WriteLine(@"As you begin to speak, the guard listens attentively, nodding occasionally as you explain your purpose for entering the kingdom and where you’ve traveled from. You leave nothing out, being as honest and straightforward as possible. When you finish, the guard leans back in his chair, a small smile tugging at the corner of his mouth.

Well, that clears things up, he says, his tone much warmer now. I appreciate your honesty. Seems like there’s nothing to worry about with you.

He pauses for a moment, as if considering whether to continue, then leans in slightly, lowering his voice. The reason we were so suspicious is that there's been talk of an organization of rebels stirring up trouble. They’re not happy with the current regime and have been causing unrest in nearby towns. We’re just being extra cautious with anyone who seems... out of place.

The guard gives you a reassuring nod. But from what you’ve told me, you’re not involved in any of that. You should be fine to go about your business in the kingdom. Just be aware that tensions are high right now, so stay clear of any troublemakers.

He stands up, offering you a hand. Welcome to the kingdom. Stay safe out there.");               
handling = 0;
nuvarande_rum = 7;
Console.ReadLine();
break;

case (string)"2":
Console.WriteLine(@"As you recount your journey and the encounter with the hooded figure, the guard’s relaxed expression begins to harden. His eyes narrow, and his jaw clenches as you mention the word 'Tyrent'. The room suddenly feels much colder.

When you finish, the guard sits in silence for a moment, staring at you as if he’s weighing something heavy in his mind. Then, with a slow, deliberate movement, he closes his notepad and stands up, the chair scraping loudly against the floor.

You spoke with rebels? His voice is no longer friendly, now sharp with anger and disbelief. Do you have any idea what you’ve done? Associating with them is treason, punishable by death in this kingdom.

He steps around the table, grabbing you roughly by the arm. You’ve just signed your own death sentence, he hisses, his grip tightening. Let’s go. You’re coming with me.

Without another word, he drags you toward the door, his earlier calm replaced with fury. The relaxed interrogation is over, and the grim reality of your situation sinks in as you're led out of the room, the walls of the guardhouse closing in around you.");           // Txt !!!!   /hoded figure
handling = 0;
nuvarande_rum = 6;
Console.ReadLine();
break;
} // switch

} } // lugn interigation

} // interigation, fri, fång, rum 5



while (nuvarande_rum == 6) {  // rum 6, bribe fly?  FIX !!!!!!!!!!! later...
Console.WriteLine(@"The cell they throw you into is small and dimly lit, with rough stone walls that seem to close in on you. The air is damp and smells faintly of mold and decay. A single narrow window, barred and high above, lets in only a sliver of daylight. The floor is cold and uneven, littered with straw that offers little comfort. In one corner, a rusted bucket serves as a crude toilet, and a thin, threadbare blanket is tossed on a hard, wooden bench—your only place to rest.

Beyond the thick iron bars of your cell, the outer hallway stretches out in both directions, dimly lit by flickering torches mounted on the walls. The stone floor echoes with each footstep that passes by, a reminder of how confined you are. The corridor is lined with other cells, some empty, others housing prisoners who remain silent or mutter softly to themselves.

A few feet away from your cell, a guard sits at a small wooden table. He seems disinterested, flipping through a worn deck of cards, occasionally glancing up at the corridor. His sword and helmet rest on the table beside him, within easy reach. The dim light from the torch above casts shadows on his face, making it difficult to tell if he’s paying much attention to you or the other prisoners. But his presence is a constant reminder that escape is unlikely, and that your fate is now in the hands of the kingdom.");
Console.ReadLine();
    if (Coins == true) {} else
    {
        Console.WriteLine();
    }

}  // rum 6, bribe fly?   FIX !!!!!!!!!!! later...




Console.Clear();
while (nuvarande_rum == 7) { // Riket - lägre secktor, tavern? vägledning? Kung/tyran?
Console.WriteLine(@"After what feels like an eternity, the heavy iron doors of the penitentiary creak open, and you step out into the harsh light of day. The cold, oppressive atmosphere of the cell fades behind you as you emerge into the lower quarters of the kingdom. The streets here are narrow and winding, lined with dilapidated buildings that lean precariously against one another. The air is thick with the scent of smoke, unwashed bodies, and the faint odor of stale ale.

The lower quarters bustle with life despite the rundown surroundings. Merchants shout over each other, trying to hawk their wares from rickety stalls, while beggars sit in the shadows, their hands outstretched for spare coins. The cobblestone streets are uneven and dirty, worn down by the constant flow of carts and the shuffling feet of the city's less fortunate.

As you navigate through the chaotic streets, your eyes catch sight of a small, weathered sign swinging gently in the breeze. The faded letters spell out The Rusty Tankard. The tavern is tucked between two crumbling buildings, its wooden door scarred and well-worn. The faint sound of laughter and clinking mugs drifts from inside, a welcome contrast to the harshness of the street.

The promise of a drink and a moment’s respite draws you closer, and as you approach, you can see the warm glow of candlelight flickering through the tavern's small windows. It offers a brief escape from the world outside, even if only for a little while.");
Console.ReadLine();
Console.Clear();

Console.WriteLine(@"As you push open the heavy wooden door, a small bell above jingles, announcing your arrival. The warm, musty air of the tavern washes over you, filled with the mingled scents of ale, roasted meat, and wood smoke. The interior is crowded with patrons, most of them hunched over mugs or engaged in loud conversation.

Behind the bar, the barkeeper is busy sliding a frothy pint across the counter to a waiting customer. He barely glances up at you as you enter, but after finishing his task, he lets out a weary sigh, wiping his hands on a ragged cloth. His eyes finally meet yours, sizing you up quickly.

“Species and age?” he asks in a gruff voice, clearly accustomed to this routine. Without waiting for your reply, he reaches beneath the counter and pulls out a massive, leather-bound book. The cover is worn, the pages yellowed with age, and you can see countless names and notations scribbled within its margins. He flips it open with practiced ease, already preparing to record your details, his quill poised to write.");
Console.Clear();

Console.WriteLine(@"The barkeeper’s quill hovers over the page as he looks up from the massive book. His eyes narrow for a moment, studying your features more closely. Then, with a slight shake of his head, he mutters, “Ah, just a human, eh?”

He pauses, as if reconsidering, then raises an eyebrow. “You’re not some half-breed, are you? Can’t be bothered with that today.”

Seeing your expression and deciding it doesn’t matter, he shrugs, closing the book with a thud. “No matter,” he grumbles, reaching for a nearby mug. With a practiced motion, he pulls a pint of ale from the tap, the amber liquid foaming as it fills the mug. He sets it down in front of you with a dull thud on the counter.

“Here you go. That’ll take the edge off,” he says, already turning his attention to the next customer, his mind seemingly elsewhere.");
Console.Clear();

Console.WriteLine(@"");
Console.Clear();


Console.WriteLine(@"");
Console.Clear();

Console.WriteLine(@"");
Console.Clear();

Console.WriteLine(@"");
Console.Clear();

Console.WriteLine(@"");
Console.Clear();


}

Console.Clear();
if (Poision == true) {
Console.WriteLine("poisening");
Console.Read();
}




















































































} 

while (Dead == true){ 
Console.Clear();
Console.WriteLine("You died, Want to try again");
Console.ReadLine();
}