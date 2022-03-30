// class to render animations

class Animation {
  // attrubites
  int displayCounter;
  int fireballCounter;
  int playerCounter;

  // Methods
  void updatePlayerCounter() {  // update player counter
    if (playerCounter < 80) {
      playerCounter++;
    } else {
      playerCounter = 0;
    }
  }

  void updateFireballCounter() {  // update fireball counter
    if (fireballCounter < 40) {
      fireballCounter++;
    } else {
      fireballCounter = 0;
    }
  }

  void updateDisplayCounter() {  // update display counter
    if (displayCounter < 40) {
      displayCounter++;
    } else {
      displayCounter = 0;
    }
  }

  // render/animate images
  void playerAnimation(int x, int y) {
    // player mage animation
    if (playerCounter <= 40) {
      image(loadImage.player_witch_1, x, y);
    } else if (playerCounter <= 80) {
      image(loadImage.player_witch_2, x, y);
    }
    // player cloud animation
    if (playerCounter <= 10) {
      image(loadImage.player_cloud_1, x - 20, y + 20, 200, 200);
    } else if (playerCounter <= 20) {
      image(loadImage.player_cloud_1, x - 19, y + 19, 190, 200);
    } else if (playerCounter <= 30) {
      image(loadImage.player_cloud_1, x - 18, y + 18, 180, 200);
    } else if (playerCounter <= 40) {
      image(loadImage.player_cloud_1, x - 17, y + 17, 170, 200);
    } else if (playerCounter <= 50) {
      image(loadImage.player_cloud_1, x - 16, y + 16, 160, 200);
    } else if (playerCounter <= 60) {
      image(loadImage.player_cloud_1, x - 17, y + 17, 170, 200);
    } else if (playerCounter <= 70) {
      image(loadImage.player_cloud_1, x - 18, y + 18, 180, 200);
    } else if (playerCounter <= 80) {
      image(loadImage.player_cloud_1, x - 19, y + 19, 190, 200);
    }
  }
  // fireballs
  void fireballAnimation(int x, int y, int size) {
    if (animation.fireballCounter <= 10) {
      image(loadImage.fireballs[0], x, y, size, size);
    } else if (animation.fireballCounter <= 20) {
      image(loadImage.fireballs[1], x, y, size, size);
    } else if (animation.fireballCounter <= 30) {
      image(loadImage.fireballs[2], x, y, size, size);
    } else if (animation.fireballCounter <= 40) {
      image(loadImage.fireballs[3], x, y, size, size);
    }
  }
  // Dragons
  void blueDragonAnimation(int x, int y, int dragonCounter) {  // animation for the blue dragon
    if (dragonCounter <= 10) {
      image(loadImage.blue_dragon[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.blue_dragon[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.blue_dragon[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.blue_dragon[1], x, y);
    }
  }

  void redDragonAnimation(int x, int y, int dragonCounter) {  // animation for the red dragon
    if (dragonCounter <= 10) {
      image(loadImage.red_dragon[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.red_dragon[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.red_dragon[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.red_dragon[1], x, y);
    }
  }

  void goldDragonAnimation(int x, int y, int dragonCounter) {  // animation for the gold dragon
    if (dragonCounter <= 10) {
      image(loadImage.gold_dragon[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.gold_dragon[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.gold_dragon[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.gold_dragon[1], x, y);
    }
  }
  // start screen dragons
  void textGoldDragon(int x, int y, int dragonCounter) {  // animation for the gold dragon on mouse hover
    if (dragonCounter <= 10) {
      image(loadImage.gold_dragon_mouse[0], x, y);
    } else if (dragonCounter <= 20) {
      image(loadImage.gold_dragon_mouse[1], x, y);
    } else if (dragonCounter <= 30) {
      image(loadImage.gold_dragon_mouse[2], x, y);
    } else if (dragonCounter <= 40) {
      image(loadImage.gold_dragon_mouse[1], x, y);
    }
  }

  void slidingRedDragon(int x, int y, int dragonCounter, int size) {  // animation for the sliding the dragon on start screen
    if (dragonCounter <= 10) {
      image(loadImage.red_dragon_front[0], x, y, size, size);
    } else if (dragonCounter <= 20) {
      image(loadImage.red_dragon_front[1], x, y, size, size);
    } else if (dragonCounter <= 30) {
      image(loadImage.red_dragon_front[2], x, y, size, size);
    } else if (dragonCounter <= 40) {
      image(loadImage.red_dragon_front[1], x, y, size, size);
    }
  }
}  // end of 'Animation' class
