// creating a defenderz game

//global variables and importing image to variable for background
PImage background;
int bgX=0;
// game score variables
int timer;
int score;
// framecounter is used to display explosion images on screen for a number of frames.
int frameCounter;

// referencing the class
Defender player;
Alien alien1;
Alien alien2;
Alien alien3;
Alien alien4;
Alien alien5;
Bullet bullet;
Asteroid asteroid1;
Asteroid asteroid2;
Asteroid asteroid3;
Asteroid asteroid4;

// creating an arraylist for the asteroids
ArrayList<Asteroid> asteroidList = new ArrayList<Asteroid>();


void setup() { 
  size(800, 400); 
  // declaring image to variables
  background = loadImage("spaceBackground.jpg"); 
  background.resize(width, height); //set image to be same size as the canvas
  alienExplosion = loadImage("explosion.png"); 
  alienExplosion.resize(width/8, height/8); 
  asteroidExplosion = loadImage("poof.png");
  asteroidExplosion.resize(width/12, height/8);
  // calling to procedure to create objects for the classes
  gameStart();
}

void draw () { 
  // move background
  drawBackground();
  // if first frame then stop game from starting until key pressed & setup objects
  if (frameCount <= 1) {
    gameStart();
  }
  
  // make asteroids using ArrayList
  for (int i=0; i<asteroidList.size(); i++) {
    asteroidList.get(i).update();
  }
  
  // displaying score
  totalScore();
  // add seconds to timer
  timer();
  // update objects
  renderObjects();
  // showing image if alien or asteroid is destroyed
  alienDestroyedImage();
  asteroidDestroyedImage();
  // bullet been shot procedure
  bulletShot();
  // bullet hitting alien/asteroid procedure
  bulletHit();
  // checking for collision with defender and alien
  crashed();
  // check key press
  checkKeys();
}

void makeAsteroids() {  // procedure to make list of asteroids
  Asteroid asteroidObject;
  for (int object=1; object<=10; object++) {
    asteroidObject = new Asteroid(int(random(800, 1000)), int(random(20, 380)), int(random(5, 11)), int(random(10, 21)), int(random(1, 4)));
    asteroidList.add(asteroidObject);
  }
}


// key functions
void keyPressed() {  // change boolean value when key pressed
  if (key == CODED) {
    if (keyCode == UP) {
      boolUP = true;
    } 
    if (keyCode == DOWN) {
      boolDOWN = true;
    }
  }
  if (key == 32) {  // 'space' key to shoot
    boolShoot = true;
    player.playerShoot();
  }
  if (key == 115) {  // 's' key to start the game
    loop();
  }
}

void keyReleased() {  // change boolean values when key released
  if (key == CODED) {
    if (keyCode == UP) {  // move the defender using arrow 'UP' and 'DOWN' keys
      boolUP = false;
    } 
    if (keyCode == DOWN) {
      boolDOWN = false;
    }
    if (key == 32) {  // 'space' key to shoot
      bullet.y = player.y;
      boolShoot = false;
      player.playerShoot();
    }
  }
}

void checkKeys() {  // allow the player to move and shoot at the same time by assigning key press to boolean variables
  if (boolUP == true) {
    player.playerMove();
  }
  if (boolDOWN == true) {
    player.playerMove();
  }
}

// Procedures

void renderObjects() {  // update all objects to be displayed on screen
  // rendering the objects on screen
  player.update();
  alien1.update();
  alien2.update();
  alien3.update();
  alien4.update();
  alien5.update();
  asteroid1.update();
  asteroid2.update();
  asteroid3.update();
  asteroid4.update();
}

// checking whether crash has occured (with bullet)
void bulletHit() {
  // checking if bullet has hit alien
  if (alien1.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien2.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien3.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien4.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (alien5.isShot(bullet) == true) {
    bullet.removeBullet();
  }
  // checking if the bullet has hit the asteroid
  if (asteroid1.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (asteroid2.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (asteroid3.isShot(bullet) == true) {
    bullet.removeBullet();
  } else if (asteroid4.isShot(bullet) == true) {
    bullet.removeBullet();
  }
  // arrayList asteroids collision with bullet
  for (int i=0; i<asteroidList.size(); i++) {
    if (asteroidList.get(i).isShot(bullet)) {
      bullet.removeBullet();
    }
  }
}

void crashed() {  // end the game if crash occurs
  if (player.drawCrashLine() == true) {
    // filling background to display final score
    fill(0);
    rect(0, 0, 800, 400);
    // displaying text for score and 'game over'
    textSize(30);
    fill(255, 0, 0);
    textAlign(CENTER);
    text("GAME OVER!", width/2, (height/2) - 60);
    fill(255);
    text("Time: " + timer + " seconds", width/2, (height/2));
    text("Score: " + score, width/2, (height/2) + 40);
    text("Press 's' to play again!", width/2, (height/2) + 100);
    // reset game
    resetGame();
    noLoop();
  }
}

void alienDestroyedImage() {  // display image if alien is destroyed
  // displaying explosion image for selected number of frames
  if (alienExplosionBool == true) {
    if (frameCount <= frameCounter + 10) {
      // display explosion image
      imageMode(CENTER);
      image(alienExplosion, alienImageX, alienImageY);
    } else {
      alienExplosionBool = false;
    }
  }
}

void asteroidDestroyedImage() {  // display image if asteroid is destroyed
  // displaying 'poof' image for selected number of frames
  if (asteroidImageBool == true) {
    if (frameCount <= frameCounter + 10) {
      // display explosion image
      imageMode(CENTER);
      image(asteroidExplosion, asteroidImageX, asteroidImageY);
    } else {
      asteroidImageBool = false;
    }
  }
}

void bulletShot() {  // make defender shoot bullet
  // if bullet shot, then move bullet
  if (shoot == true) {
    bullet.update();
  }
}

// procedures to setup game score, time and background
void drawBackground() {  // moving the background image from right to left
  imageMode(CORNER);
  //scrolling background image 
  image(background, bgX, 0); //draw image to fill the canvas 
  //draw image again off the right of the canvas 
  image(background, bgX+background.width, 0);     
  bgX = bgX- 4; 

  if (bgX == -background.width) { //if first image completely off the canvas
    bgX=0; //reset back to initial value background
  }
}

void totalScore() {  // display score on screen
  fill(255, 0, 0);
  textSize(25);
  text(score, width/2, 50);
}

void timer() {  // add 1s to the timer every 60 frames
  if (frameCount % 60 == 0) {
    timer +=1;
  }
}

void gameStart() {  // setup objects for game
  // creating objects to pass into the classes
  // defender
  player = new Defender(200);
  // alien
  alien1 = new Alien(800, 200);
  alien2 = new Alien(1000, 350);
  alien3 = new Alien(1000, 50);
  alien4 = new Alien(1200, 150);
  alien5 = new Alien(1200, 300);
  // bullet
  bullet = new Bullet();
  // asteroid
  asteroid1 = new Asteroid(int(random(800, 1000)), int(random(20, 380)), int(random(5, 11)), int(random(10, 21)), int(random(1, 4)));
  asteroid2 = new Asteroid(int(random(800, 1000)), int(random(20, 380)), int(random(5, 11)), int(random(10, 21)), int(random(1, 4)));
  asteroid3 = new Asteroid(int(random(800, 1000)), int(random(20, 380)), int(random(5, 11)), int(random(10, 21)), int(random(1, 4)));
  asteroid4 = new Asteroid(int(random(800, 1000)), int(random(20, 380)), int(random(5, 11)), int(random(10, 21)), int(random(1, 4)));
  // asteroids in ArrayList
  if (frameCount % 60 == 0) {
    makeAsteroids();
  }
  // text on screen how to start the game
  textSize(20); 
  fill(255, 0, 0);
  textAlign(CENTER);
  text("Press 's' to start", width/2, height/2);
  // removing bug of bullet being able to be rendered by player when game has not started
  bullet.removeBullet();
  // preventing game from starting
  noLoop();
}

void resetGame() {  // resetting the game values once game has ended
  // reset framerate/scores for new game
  frameCount = 0;
  score = 0;
  timer = 0;
  asteroidList.clear();
}
