# BO opdracht

## flowchart voor enemy wave system

````mermaid
flowchart TD
    start((Start)) --> spawn_w(make random enemy list)
    spawn_w --> checken(spawn wave)
    checken --> spawn_e(spawn enemies every 0.5 sec)
    spawn_e --> reached_base{enemy reached end?}
    reached_base -->|yes| lose_life(player loses a life)
    reached_base -->|no| money(enemy dead)
    lose_life --> wave_done{all enemys dead}
    lose_life --> dead{is HP 0}
    dead -->|yes| end_game(end game)
    end_game --> again{play again}
    again -->|yes| start
    again -->|no| quit((stop))
    dead -->|no| wave_done
    money --> wave_done
    wave_done -->|no| reached_base
    wave_done -->|yes| no_more_waves(next wave)
    no_more_waves --> start_wave
    start_wave --> spawn_w
````
