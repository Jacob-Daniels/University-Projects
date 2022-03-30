// Projectile class

class Projectile extends Entity {
  // Attributes
  int imageType;
  int rotateType;
  float rotateImage;

  // Constructor
  Projectile(int x, int y, int size, int speed, int imageType, int rotateType) {
    super(x, y, size, speed);
    this.imageType = imageType;
    this.rotateType = rotateType;
  }

  // Methods
  void render() {
    imageMode(CENTER);
    for (int i=0; i < loadImage.randomImage.length; i++) {
      loadImage.randomImage[i].resize(size, size);
    }
    // rotating the projectile image
    pushMatrix();  // open matrix temporarily
    translate(x, y);  // translate to new position
    rotateZ(rotateImage);
    translate(0, 0);  // translate to origional position
    image(loadImage.randomImage[imageType], 0, 0);
    popMatrix();  // close matrix
  }

  void move() {
    if (this.y < 1000) {
      checkRotation();
      this.y += speed;
    } else {
      projectileList.remove(this);
    }
  }

  void checkRotation() {  // increase angle of rotation depending on direction
    if (this.rotateType == 1) {
      if (rotateImage < 6.3) {  // rotate image right
        rotateImage += 0.1;
      } else {
        rotateImage = 0;
      }
    } else {
      if (rotateImage > -6.3) {  // rotate image left
        rotateImage -= 0.1;
      } else {
        rotateImage = 0;
      }
    }
  }

  void collision() {  // collision between player projectile and enemies
    for (int i=0; i < blueDragonList.size(); i++) {  // blue dragon hit
      if (this.boolCollisionProjectile(blueDragonList.get(i)) == true) {
        // remove enemy
        blueDragonList.remove(blueDragonList.get(i));
        // add to score
        player.playerScore(blueDragon.point);
        // remove projectile
        projectileList.remove(this);
        // create new enemy
        enemy.createEnemy();
      }
    }
    for (int i=0; i < redDragonList.size(); i++) {  // blue dragon hit
      if (this.boolCollisionProjectile(redDragonList.get(i)) == true) {
        // remove enemy
        redDragonList.remove(redDragonList.get(i));
        // add to score
        player.playerScore(redDragon.point);
        // remove projectile
        projectileList.remove(this);
        // create new enemy
        enemy.createEnemy();
      }
    }
    for (int i=0; i < goldDragonList.size(); i++) {  // blue dragon hit
      if (this.boolCollisionProjectile(goldDragonList.get(i)) == true) {
        // remove enemy
        goldDragonList.remove(goldDragonList.get(i));
        // add to score
        player.playerScore(goldDragon.point);
        // remove projectile
        projectileList.remove(this);
        // create new enemy
        enemy.createEnemy();
      }
    }
  }

  // returns true if collision occurs
  boolean boolCollisionProjectile(Entity other) {  // detecting collision between enemies
    if (dist(other.x, other.y, this.x, this.y) < (this.size - 5)) {
      // add position of enemy to deathList
      deathAnimation = new DeathAnimation(other.x, other.y, 115);
      deathList.add(deathAnimation);
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Projectile' class
