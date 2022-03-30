// blue dragon class

public class DragonBlue extends Enemy {
  // attributes
  final int point = 1;
  final int damage = 1;
  float animationCounter;
  float xDistance = 1;
  float rotate = 0.06;

  // constructor
  DragonBlue(int x, int y, int size, int speed, int animationCounter) {
    super(x, y, size, speed);
    this.animationCounter = animationCounter;
  }
  // methods
  void render() {
    // update animation counter
    dragonCounter();
    // move dragon towards the player
    trackPlayer();
  }

  void trackPlayer() {  // moves the enemy towards the player on x axis
    if (this.y >= 500) {  // move enemy within a set range
      if (this.x - player.x > 0 && this.x - player.x < 300) {
        rotateDragon(-rotate);
        this.x -= xDistance;
      } else if (this.x - player.x < 0 && this.x - player.x > -300) {
        rotateDragon(rotate);
        this.x += xDistance;
      } else {
        straightDragon();
      }
    } else if (this.y < 500 && this.y > 250) {  // when enemy is closer to the player it moves faster
      if (this.x - player.x > 0 && this.x - player.x < 300) {
        rotateDragon(-rotate);
        this.x -= xDistance * 2;
      } else if (this.x - player.x < 0 && this.x - player.x > -300) {
        rotateDragon(rotate);
        this.x += xDistance * 2;
      } else {
        straightDragon();
      }
    } else {
      straightDragon();
    }
  }

  void straightDragon() {  // display straight image
    animation.blueDragonAnimation(x, y, (int)animationCounter);
  }

  void rotateDragon(float rotation) {  // display rotated dragon
    pushMatrix();
    translate(x, y);
    rotate(rotation);
    translate(0, 0);
    animation.blueDragonAnimation(0, 0, (int)animationCounter);
    popMatrix();
  }

  void dragonCounter() {
    // check values to increase or reset
    if (animationCounter < 40) {
      animationCounter += 1.5;
    } else {
      animationCounter = 0;
    }
  }

  void collision() {  // collision between other dragons
    for (DragonBlue dragons : blueDragonList) {
      if (checkOtherDragons(dragons) == true) {
        if (dragons.y > 1050) {  // reposition enemies if off screen
          dragons.y = int(random(1100, 1800));
          dragons.x = int(random(xLeftBorder, xRightBorder));
        }
      }
    }
  }

  boolean checkOtherDragons(DragonBlue other) {  // checks collision between other dragons
    for (DragonRed dragons : redDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    for (DragonGold dragons : goldDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    return false;
  }
}  // end of class
