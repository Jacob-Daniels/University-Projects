// load images at beginning of the application to reduce lag

class LoadImages {
  // EnemyProjectile Images
  PImage[] fireballs = {loadImage("dragon_fireball//fireball_1.png"), loadImage("dragon_fireball//fireball_2.png"), loadImage("dragon_fireball//fireball_3.png"), loadImage("dragon_fireball//fireball_4.png")};
  // enemy death images
  PImage[] deathImage = {loadImage("poof//poof_1.png"), loadImage("poof//poof_2.png"), loadImage("poof//poof_3.png"), loadImage("poof//poof_4.png"), loadImage("poof//poof_5.png"), loadImage("poof//poof_6.png"), loadImage("poof//poof_7.png"), loadImage("poof//poof_8.png"), loadImage("poof//poof_9.png"), loadImage("poof//poof_10.png"), loadImage("poof//poof_11.png"), loadImage("poof//poof_12.png"), loadImage("poof//poof_13.png"), loadImage("poof//poof_14.png"), loadImage("poof//poof_15.png"), loadImage("poof//poof_16.png"), loadImage("poof//poof_17.png"), loadImage("poof//poof_18.png"), loadImage("poof//poof_19.png"), loadImage("poof//poof_20.png"), loadImage("poof//poof_21.png"), loadImage("poof//poof_22.png"), loadImage("poof//poof_23.png"), };
  // Animation Images
  PImage[] blue_dragon = {loadImage("dragons//blue_dragon_1.png"), loadImage("dragons//blue_dragon_2.png"), loadImage("dragons//blue_dragon_3.png")};
  PImage[] red_dragon = {loadImage("dragons//red_dragon_1.png"), loadImage("dragons//red_dragon_2.png"), loadImage("dragons//red_dragon_3.png")};
  PImage[] gold_dragon = {loadImage("dragons//gold_dragon_1.png"), loadImage("dragons//gold_dragon_2.png"), loadImage("dragons//gold_dragon_3.png")};
  PImage[] red_dragon_front = {loadImage("dragons//red_dragon_front_1.png"), loadImage("dragons//red_dragon_front_2.png"), loadImage("dragons//red_dragon_front_3.png")};
  PImage[] gold_dragon_mouse = {loadImage("dragons//gold_dragon_left_1.png"), loadImage("dragons//gold_dragon_left_2.png"), loadImage("dragons//gold_dragon_left_3.png")};
  // Player Images
  PImage player_witch_1 = loadImage("witch//witch_1.png");
  PImage player_witch_2 = loadImage("witch//witch_2.png");
  PImage player_cloud_1 = loadImage("cloud_1.png");
  // Projectile Images
  PImage[] randomImage = {loadImage("potions//potion_1.png"), loadImage("potions//potion_2.png"), loadImage("potions//potion_3.png"), loadImage("potions//potion_4.png"), loadImage("potions//potion_5.png"), loadImage("potions//potion_6.png")};
  // Display Images
  PImage heart = loadImage("heart.png");
  PImage grey_heart = loadImage("grey_heart.png");
  PImage backgroundImage = loadImage("background.png");
  PImage start = loadImage("text//start.png");
  PImage quit = loadImage("text//quit.png");
  PImage howToPlay = loadImage("text//how_to_play.png");
  PImage controls = loadImage("text//controls.png");
  PImage scoreboard = loadImage("text//scoreboard.png");
  PImage restart = loadImage("text//restart.png");
  PImage back = loadImage("text//back.png");
  PImage gameoverImage = loadImage("text//game_over.png");
  PImage submitImage = loadImage("text//submit.png");
}  // end of 'LoadImages' class
