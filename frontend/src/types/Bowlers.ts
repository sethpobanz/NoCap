export interface Team {
  teamId: number;
  teamName: string;
  captainId: number;
  bowlers: any[]; // Assuming this is an array of bowlers
  tourneyMatchEvenLaneTeams: any[]; // Assuming these are arrays of some other type
  tourneyMatchOddLaneTeams: any[]; // Assuming these are arrays of some other type
}

export interface Bowlers {
  bowlerId: number;
  bowlerLastName?: string;
  bowlerFirstName?: string;
  bowlerMiddleInit?: string | null;
  bowlerAddress?: string;
  bowlerCity?: string;
  bowlerState?: string;
  bowlerZip?: string;
  bowlerPhoneNumber?: string;
  team?: Team; // Update to have a nested team object
}
