# Design Document

- [Design Document](#design-document)
  - [Target Audience](#target-audience)
  - [Purpose](#purpose)
  - [What is a Habit?](#what-is-a-habit)
  - [Planned Features](#planned-features)
    - [Minimally Required Features](#minimally-required-features)
      - [Habit Records](#habit-records)
      - [Habit Completion Calendar](#habit-completion-calendar)
      - [Arbitrarily Set Schedule](#arbitrarily-set-schedule)
      - [Custom Day Period](#custom-day-period)
      - [Task List for My Day](#task-list-for-my-day)
    - [Enhancing Features](#enhancing-features)
      - [Homescreen Widget for My Day](#homescreen-widget-for-my-day)
      - [Alerts](#alerts)
      - [Habit Grouping](#habit-grouping)
      - [Habit Sorting, Custom](#habit-sorting-custom)
      - [Dark Theme](#dark-theme)
      - [Data Importation and Exportation](#data-importation-and-exportation)
    - [Bonus Features](#bonus-features)
      - [Onboarding](#onboarding)
      - [Data Visualization](#data-visualization)
      - [Shortcuts](#shortcuts)
      - [Time zone Locking](#time-zone-locking)
      - [Integration with Microsoft To-Do](#integration-with-microsoft-to-do)

## Target Audience

The target audience for this app is myself.

## Purpose

The goal of the HabitTracker is to track the completion of habits and their completion history.

## What is a Habit?

A habit is a task that reoccurs over period of time. It is expected there will be instances where an individual fails to complete the task when desired, but it is important to try at the next available opportunity.

## Planned Features

### Minimally Required Features

These are the features required to meet the most basic version of the purpose and those which have an influence over how data is structured and contextualized.

#### Habit Records

Record the datetime when a habit is completed.

#### Habit Completion Calendar

Display a 2-d list showing the days and habits, populated with whether a habit was completed on a given day. The list should be scrollable over both the x and y axes.

|      | Day n | Day n-1 | Day n-2 | Day n-3 |
|------|:-----:|:-------:|:-------:|:-------:|
Habit 1 | x | ✓ | ✓ | x |
Habit 2 | ✓ | ✓ | ✓ | x |
Habit 3 | x | x | x | x |
Habit 4 | ✓ | x | x | ✓ |

#### Arbitrarily Set Schedule

Allow for the habit to repeat over a user provided period.
There should be three states: completed today, period goals met, and incomplete.

#### Custom Day Period

Allow for 24 hour periods to start at any time, not just midnight. I frequently stay up past midnight and conceptualize my day around sleep.

#### Task List for My Day

Display the list of tasks to be completed during the day.

### Enhancing Features

These are the features that directly contribute to increasing the efficiency of the app's purpose and justify its existence alongside competing applications.

#### Homescreen Widget for My Day

Allow for the tasks of the day to be viewed and completed from the homescreen.

#### Alerts

Notify user when a habit becomes available.

#### Habit Grouping

Allow for habits to be grouped together e.g. Construction and destruction.

#### Habit Sorting, Custom

Allow for the sorting of habits and groups by:

- name
- availability start
- availability end
- custom value

#### Dark Theme

Color scheme designed to look pleasing and convey distinction between categories on a black background.

#### Data Importation and Exportation

Export and import data for data science and transfer of app state across devices.

### Bonus Features

These are features that solve niche issues not directly related to the app's purpose or go beyond the initial scope.

#### Onboarding

Educate new users on how the app represents and structures habits.

#### Data Visualization

Provide visualizations for statistical information:

- [] number of occurrences over a provided period
- [] calendar view for an individual habit

#### Shortcuts

Provide an API for actions to be called:

- completion of a habit

#### Time zone Locking

Set a habit to use a specified time zone rather than using system time.

#### Integration with Microsoft To-Do

Have a single widget that displays tasks from Habit Tracker and Microsoft To-Do.
