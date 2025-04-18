Hello there.  Do I know you?
 * [Yes] Yes, I am a villager from your town. 
    -> HappyReaction
 * [No] No, I was just passign through this village on my adventure.  
    -> NormalReaction
 
 
 ==NormalReaction==
 Oh, then welcome!  I am the Mayor of Homestead.  I watch over the town and protect it's people from the log monsters.  Recently, we had an issue with the log monsters, would you mind helping me with a quest? 
 -> DialogueDecision
 
 
 ==HappyReaction==
 Oh goodie! So you know your way around the town alreaady. 
 Do you have something for me?  
 * [No] Nope
 -> QuestGive
 * [Yes] Yes, I brought back Hawkeye's Bow.
 -> QuestComplete
 
 ==QuestGive==
 Would you like to go on a quest for me?  
 -> DialogueDecision
 
 
 ==DialogueDecision==
 * [Yes] Of course! What do you need me to do? 
    -> QuestDetails
 * [No] No thanks, a quest sounds dangerous and I don't want to die. 
    -> Persistent
 
 
 ==Persistent==
 Oh please help me... I need to stay and watch the town, so I can't do it myself.  Would you reconsider helping me?
 
 * [Yes] Sure, I can help since you have to take care of the town. 
    -> QuestDetails
 * [Yes] I don't have a choice, so sure. 
    -> QuestDetails
 
 
 ==QuestDetails==
 Great!  I need you to retrieve the Hawkeye's Legendary Bow from the Log Monsters' Lair.  Any Questions?
 ->QuestChoices
 
 
 ==FollowUp==
 Is there anything else you want to know?
 ->QuestChoices
 
 
 ==QuestChoices==
 * [Who is that?] Who is Hawkeye?
 -> HawkeyeLore
 * [What happened?] How did the log monsters get the bow?
 -> MonsterRaid
 * [Where is it?] Where is the lair?
 -> BowLocation
 * [How?] How do I enter the lair?
 -> KeyLocation
 * [Monsters?] What is a log monster?
 -> LogMonsters
 * [Then what?] What do I do when I get the bow?
 -> QuestGoal
 * [Nope] Nope, I got this.
 -> Exit
 
 
 ==HawkeyeLore==
 Hawkeye was a legendary hero that protected Homestead.  
 One day, he disappeared, nobody knew where he went or what had happened to him.  The only thing we did know, was that he left behind his legendary bow.  
 As the mayor of the town, I wanted to pay tribute to Hawkeye, so I put it on display in the village. 
 + [Next]
 -> FollowUp
 
 ==MonsterRaid==
 Recently the log monsters stormed the town destroying a lot of homes and killing a few of our beloved villagers.  
 They saw the bow on display and stole it because they always hated Hawkeye.
 + [Next]
 -> FollowUp
 
 
 ==BowLocation==
 They took the bow back to their lair hidden in the cave located south of here and locked it in a chest behind their locked door.  
 The lair door requires a key in order to open the door.  
 The cave entrance is near the graveyard of the villagers that lost their lives in the raid.  
 + [Next]
 -> FollowUp
 
 
 ==KeyLocation==
 The key is somewhere near my favorite fishing spot that's North of here.  
 Last I heard, the log monsters put it in a chest so they wouldn't drop it in the water.    
 + [Next]
 -> FollowUp
 
 
 ==LogMonsters==
 Log Monsters are the hideous creatures that lurk in the forests around Homestea.
 Ancient legends say that they are goblins that liked to roll down hills.  
 But one day, they couldn't stop rolling and they ended up rolling into a log, getting stuck in there forever.
 + [Next]
 -> FollowUp
 
 
 ==QuestGoal==
 Bring the bow back to me for a reward.
 -> FollowUp
 
 ==QuestComplete==
 Oh great! Actually you can keep it.  I am actually Hawkeye.  You seem worthy of my bow.  Treat it well.
 + [End Quest]
    -> END
 
 ==Exit==
I wish you good luck on your quest.  
    -> END
